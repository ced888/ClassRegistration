using ClassRegistry.ClassRegistryDataSet1TableAdapters;
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


namespace ClassRegistry
{
    public partial class Form1 : Form
    {
        string connectionString = Properties.Settings.Default.ClassRegistryConnectionString1;
        //variable to store the logged in student's ID
        public int? loggedInStudentID = null;
        public int cartCounter = 0;
        public int scheduleCounter = 0;

        public Form1()
        {
            InitializeComponent();
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

                    //Getting the Student's name, there's probably a better way
                    var studentName = studentResults[0]["first_name"].ToString().Trim() + " "
                        + studentResults[0]["last_name"].ToString().Trim();


                    MessageBox.Show("You have successfully logged in!");
                    loggedInLabel.Visible = true;
                    loggedInLabel.Text = "Logged in as: " + studentID + " : " + studentName;
                    logOut.Visible = true;
                    loginButton.Visible = false;
                    iDField.ReadOnly = true;
                    removeFromCartButton.Visible = true;
                    btn_addToCart.Visible = true;

                    dataGridView_CourseData_Bind(dataGridView_Cart, "sp_course_sections_by_cart");
                    dataGridView_CourseData_Bind(dataGridView_Enrolled, "sp_get_enrolled");

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
            refreshCourseSections();
        }

        private void refreshCourseSections()
        {
            if (dataGridView_Course.Rows.Count > 0)
            {
                //Grab the data row selected from the grid
                DataRowView row = (DataRowView)dataGridView_Course.SelectedRows[0].DataBoundItem;
                //Grabs the course_id int
                int x = (int)row.Row.ItemArray[1];
                //Fills the course section data grid with current selected course
                this.sp_course_Sections_by_course_IDTableAdapter.Fill(this.classRegistryDataSet1.sp_course_Sections_by_course_ID, x);
            }
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)dataGridView_CourseSections.SelectedRows[0].DataBoundItem;
            //Grabs the course_section id and course id integers
            int course_sectionID = (int)row.Row.ItemArray[6];
            int timeSlotId = (int)row.Row.ItemArray[4];


            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand sqlCmd = new SqlCommand("sp_add_to_cart", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@studentId", loggedInStudentID);
                sqlCmd.Parameters.AddWithValue("@timeSlotId", timeSlotId);
                sqlCmd.Parameters.AddWithValue("@courseSectionId", course_sectionID);

                SqlCommand sqlCmdGetCourseCount = new SqlCommand("sp_get_course_count_from_cart", sqlCon);
                sqlCmdGetCourseCount.CommandType = CommandType.StoredProcedure;
                sqlCmdGetCourseCount.Parameters.AddWithValue("@studentId", loggedInStudentID);

                try
                {
                    sqlCon.Open();
                    sqlCmdGetCourseCount.ExecuteNonQuery();
                    cartCounter = (int)sqlCmdGetCourseCount.ExecuteScalar();
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                SqlCommand sqlCmdCheckPreReq = new SqlCommand("sp_getPreReqsNotTaken", sqlCon);
                sqlCmdCheckPreReq.CommandType = CommandType.StoredProcedure;
                sqlCmdCheckPreReq.Parameters.AddWithValue("@Student1", loggedInStudentID);
                sqlCmdCheckPreReq.Parameters.AddWithValue("@courseSecId", course_sectionID);
                List<int> prereqsNotTaken = new List<int>();

                try
                {
                    sqlCon.Open();
                    using (SqlDataReader reader = sqlCmdCheckPreReq.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int prereqId = reader.GetInt32(reader.GetOrdinal("PreReqsNotTaken"));
                                prereqsNotTaken.Add(prereqId);
                            }
                        }
                    }
                    sqlCon.Close();
                }
                catch (Exception exc)
                {
                    System.Windows.Forms.MessageBox.Show(exc.Message);
                }

                if (prereqsNotTaken.Count == 0)
                {
                    try
                    {

                        if (cartCounter < 5)
                        {
                            sqlCon.Open();
                            sqlCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Error: Course limit of 5 reached");
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                else
                {

                    SqlCommand sqlCmdGetCourseName = new SqlCommand("sp_get_course_name", sqlCon);
                    sqlCmdGetCourseName.CommandType = CommandType.StoredProcedure;
                    string prereqString = "";
                    foreach (int prereq in prereqsNotTaken)
                    {
                        string courseName;
                        sqlCmdGetCourseName.Parameters.AddWithValue("@courseId", prereq);
                        try
                        {
                            sqlCon.Open();
                            courseName = sqlCmdGetCourseName.ExecuteScalar().ToString().TrimEnd();
                            prereqString += courseName + ", ";
                        }
                        catch (Exception exc)
                        {
                            System.Windows.Forms.MessageBox.Show(exc.Message);
                        }


                    }
                    System.Windows.Forms.MessageBox.Show("The follow prereqs are required: " + prereqString);
                }

            }
            dataGridView_CourseData_Bind(dataGridView_Cart, "sp_course_sections_by_cart");

        }

        private void removeFromCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DataRowView row = (DataRowView)dataGridView_CourseSections.SelectedRows[0].DataBoundItem;
                //Grabs the course_section id and course id integers
                DataRowView row = (DataRowView)dataGridView_Cart.SelectedRows[0].DataBoundItem;
                int course_sectionID = (int)row.Row.ItemArray[0];
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCmd = new SqlCommand("sp_remove_course_from_cart", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@studentId", loggedInStudentID);
                    sqlCmd.Parameters.AddWithValue("@courseSectionId", course_sectionID);

                    try
                    {

                        sqlCon.Open();
                        sqlCmd.ExecuteNonQuery();
                        dataGridView_Cart_Bind();



                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                dataGridView_Cart_Bind();

            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show("Cart is empty");
            }

        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)dataGridView_Cart.SelectedRows[0].DataBoundItem;
            //Grabs the course_section id and course id integers
            int course_sectionID = (int)row.Row.ItemArray[0];

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand sqlCmd = new SqlCommand("sp_add_enrolled", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@studentId", loggedInStudentID);
                sqlCmd.Parameters.AddWithValue("@courseSectionId", course_sectionID);

                SqlCommand sqlCmdRemove = new SqlCommand("sp_remove_course_from_cart", sqlCon);
                sqlCmdRemove.CommandType = CommandType.StoredProcedure;
                sqlCmdRemove.Parameters.AddWithValue("@studentId", loggedInStudentID);
                sqlCmdRemove.Parameters.AddWithValue("@courseSectionId", course_sectionID);




                try
                {
                    if (scheduleCounter < 5)
                    {
                        sqlCon.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmdRemove.ExecuteNonQuery();
                        scheduleCounter += 1;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Error: Course limit of 5 reached");
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            dataGridView_CourseData_Bind(dataGridView_Enrolled, "sp_get_enrolled");
            dataGridView_CourseData_Bind(dataGridView_Cart, "sp_course_sections_by_cart");
            refreshCourseSections();
        }

        private void btn_dropCourse_Click(object sender, EventArgs e)
        {
            //int row = dataGridView_Enrolled.CurrentCell.RowIndex;
            //dataGridView_Enrolled.Rows.RemoveAt(row);

            DataRowView row = (DataRowView)dataGridView_Enrolled.SelectedRows[0].DataBoundItem;
            int course_sectionID = (int)row.Row.ItemArray[0];

            RemovefromDataGrid(dataGridView_Enrolled, "sp_remove_course_from_enrolled", course_sectionID, scheduleCounter);

            dataGridView_CourseData_Bind(dataGridView_Enrolled, "sp_get_enrolled");

            refreshCourseSections();
        }

        /// <summary>
        /// Helper function to bind course data to data grids
        /// </summary>
        /// <param name="datagrid">Data Grid View to update</param>
        /// <param name="spName">Stored procedure of get function</param>
        private void dataGridView_CourseData_Bind(DataGridView datagrid, string spName)
        {
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                {
                    datagrid.Refresh();
                    sqlConnect.Open();
                    SqlCommand sqlCmd = new SqlCommand(spName, sqlConnect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@student_ID", loggedInStudentID);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    datagrid.DataSource = dataTable;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Helper function for removing courses from grid
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <param name="course_sectionID"></param>
        private void RemovefromDataGrid(DataGridView dataGrid, string spName, int course_sectionID, int counter)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand sqlCmd = new SqlCommand(spName, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@studentId", loggedInStudentID);
                sqlCmd.Parameters.AddWithValue("@courseSectionId", course_sectionID);

                try
                {
                    sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    if (counter > 0)
                    {
                        counter -= 1;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        private void dataGridView_Cart_Bind()
        {
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                {
                    dataGridView_Cart.Refresh();
                    sqlConnect.Open();
                    SqlCommand sqlCmd = new SqlCommand("sp_course_sections_by_cart", sqlConnect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@student_ID", loggedInStudentID);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView_Cart.DataSource = dataTable;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}