﻿using ClassRegistry.ClassRegistryDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace ClassRegistry
{  
    public partial class Form1 : Form
    {
        private string connectionString;

        //variable to store the logged in student's ID
        public int? loggedInStudentID = null;


        public Form1()
        {
            InitializeComponent();
            connectionString = "Server=group-6.database.windows.net;Database=ClassRegistry;User Id=group6;Password=Test123456;";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRegistryDataSet1.Course_Sections' table. You can move, or remove it, as needed.
            this.course_SectionsTableAdapter.Fill(this.classRegistryDataSet1.Course_Sections);
            try
            {
                this.sp_search_by_course_nameTableAdapter.Fill(this.classRegistryDataSet1.sp_search_by_course_name, search_stringToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void search_stringToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void search_stringToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sp_search_by_course_nameTableAdapter.Fill(this.classRegistryDataSet1.sp_search_by_course_name, search_stringToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Grab the data row selected from the grid
            DataRowView row = (DataRowView)dataGridView_Course.SelectedRows[0].DataBoundItem;
            //Grabs the course_id int
            int x = (int) row.Row.ItemArray[1];
            //Fills the course section data grid with current selected course
            this.sp_course_Sections_by_course_IDTableAdapter.Fill(this.classRegistryDataSet1.sp_course_Sections_by_course_ID, x);
        }

        private void RefreshCartDataGridView()
        {
  
            var tableAdapter = new ClassRegistryDataSet1TableAdapters.CartDataTable1Adapter();


            var dataTable = new ClassRegistryDataSet1.CartDataTable1DataTable();

            tableAdapter.Fill(dataTable, loggedInStudentID.Value); // Assuming loggedInStudentID is the parameter value

            foreach (DataColumn column in dataTable.Columns)
            {
                Console.WriteLine($"Column Name: {column.ColumnName}, Data Type: {column.DataType}");
            }


            dataGridView_Cart.DataSource = dataTable;
             
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)dataGridView_CourseSections.SelectedRows[0].DataBoundItem;
            int course_sectionID = (int)row.Row.ItemArray[6];
            int courseID = (int)row.Row.ItemArray[5];

            // Insert into Cart table
            string sql = $"INSERT INTO Cart (student_ID, course_section_ID) VALUES ({loggedInStudentID}, {course_sectionID})";

            // Execute the SQL statement
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            RefreshCartDataGridView();

        }

        
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            int studentID;
            if (int.TryParse(iDField.Text, out studentID))
            {
 
                var studentsTableAdapter = new Students1TableAdapter();
                var studentResults = studentsTableAdapter.FindByStudentID(studentID);


                if (studentResults != null && studentResults.Rows.Count > 0)
                {
                    loggedInStudentID = studentID;

                    RefreshCartDataGridView();
                    //Getting the Student's name, there's probably a better way
                    var studentName = studentResults[0]["first_name"].ToString().Trim() + " "
                        + studentResults[0]["last_name"].ToString().Trim();


                    MessageBox.Show("You have successfully logged in!");
                    loggedInLabel.Visible = true;
                    loggedInLabel.Text = "Logged in as: " + studentID + " : " + studentName;
                    logOut.Visible = true;
                    loginButton.Visible = false;
                    iDField.ReadOnly = true;
                    btn_addToCart.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Student ID does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
            }

        }


        private void logOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out!");
            loggedInLabel.Visible = false;
            logOut.Visible = false;
            loginButton.Visible = true;
            iDField.ReadOnly = false;
            iDField.Clear();
            loggedInStudentID = null;
            btn_addToCart.Enabled = false;


        }

        private void dataGridView_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
