using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRegistry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
