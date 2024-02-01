namespace ClassRegistry
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spsearchbycoursenameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRegistryDataSet1 = new ClassRegistry.ClassRegistryDataSet1();
            this.sp_search_by_course_nameTableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.sp_search_by_course_nameTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.search_stringToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.search_stringToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.classRegistryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_SectionsTableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.Course_SectionsTableAdapter();
            this.coursesectionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlyenrolledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendaryearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsearchbycoursenameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 304);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(775, 141);
            this.dataGridView2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(106, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Id:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(688, 245);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add To Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cart";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(655, 451);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.button3.Size = new System.Drawing.Size(133, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Enroll to Classes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Schedule";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coursenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spsearchbycoursenameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(169, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            this.coursenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spsearchbycoursenameBindingSource
            // 
            this.spsearchbycoursenameBindingSource.DataMember = "sp_search_by_course_name";
            this.spsearchbycoursenameBindingSource.DataSource = this.classRegistryDataSet1;
            // 
            // classRegistryDataSet1
            // 
            this.classRegistryDataSet1.DataSetName = "ClassRegistryDataSet1";
            this.classRegistryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_search_by_course_nameTableAdapter
            // 
            this.sp_search_by_course_nameTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_stringToolStripLabel,
            this.search_stringToolStripTextBox});
            this.fillToolStrip.Location = new System.Drawing.Point(9, 58);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(227, 25);
            this.fillToolStrip.TabIndex = 11;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // search_stringToolStripLabel
            // 
            this.search_stringToolStripLabel.Name = "search_stringToolStripLabel";
            this.search_stringToolStripLabel.Size = new System.Drawing.Size(113, 22);
            this.search_stringToolStripLabel.Text = "Course Search:";
            this.search_stringToolStripLabel.Click += new System.EventHandler(this.search_stringToolStripLabel_Click);
            // 
            // search_stringToolStripTextBox
            // 
            this.search_stringToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_stringToolStripTextBox.Name = "search_stringToolStripTextBox";
            this.search_stringToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.search_stringToolStripTextBox.TextChanged += new System.EventHandler(this.search_stringToolStripTextBox_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coursesectionIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.timeslotIDDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.currentlyenrolledDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.calendaryearDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.courseSectionsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(184, 86);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(603, 150);
            this.dataGridView3.TabIndex = 12;
            // 
            // classRegistryDataSet1BindingSource
            // 
            this.classRegistryDataSet1BindingSource.DataSource = this.classRegistryDataSet1;
            this.classRegistryDataSet1BindingSource.Position = 0;
            // 
            // courseSectionsBindingSource
            // 
            this.courseSectionsBindingSource.DataMember = "Course_Sections";
            this.courseSectionsBindingSource.DataSource = this.classRegistryDataSet1BindingSource;
            // 
            // course_SectionsTableAdapter
            // 
            this.course_SectionsTableAdapter.ClearBeforeFill = true;
            // 
            // coursesectionIDDataGridViewTextBoxColumn
            // 
            this.coursesectionIDDataGridViewTextBoxColumn.DataPropertyName = "course_section_ID";
            this.coursesectionIDDataGridViewTextBoxColumn.HeaderText = "course_section_ID";
            this.coursesectionIDDataGridViewTextBoxColumn.Name = "coursesectionIDDataGridViewTextBoxColumn";
            this.coursesectionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "course_ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeslotIDDataGridViewTextBoxColumn
            // 
            this.timeslotIDDataGridViewTextBoxColumn.DataPropertyName = "time_slot_ID";
            this.timeslotIDDataGridViewTextBoxColumn.HeaderText = "time_slot_ID";
            this.timeslotIDDataGridViewTextBoxColumn.Name = "timeslotIDDataGridViewTextBoxColumn";
            this.timeslotIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentlyenrolledDataGridViewTextBoxColumn
            // 
            this.currentlyenrolledDataGridViewTextBoxColumn.DataPropertyName = "currently_enrolled";
            this.currentlyenrolledDataGridViewTextBoxColumn.HeaderText = "currently_enrolled";
            this.currentlyenrolledDataGridViewTextBoxColumn.Name = "currentlyenrolledDataGridViewTextBoxColumn";
            this.currentlyenrolledDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calendaryearDataGridViewTextBoxColumn
            // 
            this.calendaryearDataGridViewTextBoxColumn.DataPropertyName = "calendar_year";
            this.calendaryearDataGridViewTextBoxColumn.HeaderText = "calendar_year";
            this.calendaryearDataGridViewTextBoxColumn.Name = "calendaryearDataGridViewTextBoxColumn";
            this.calendaryearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 638);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Class Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsearchbycoursenameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spsearchbycoursenameBindingSource;
        private ClassRegistryDataSet1 classRegistryDataSet1;
        private ClassRegistryDataSet1TableAdapters.sp_search_by_course_nameTableAdapter sp_search_by_course_nameTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel search_stringToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox search_stringToolStripTextBox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource classRegistryDataSet1BindingSource;
        private System.Windows.Forms.BindingSource courseSectionsBindingSource;
        private ClassRegistryDataSet1TableAdapters.Course_SectionsTableAdapter course_SectionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesectionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeslotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentlyenrolledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendaryearDataGridViewTextBoxColumn;
    }
}

