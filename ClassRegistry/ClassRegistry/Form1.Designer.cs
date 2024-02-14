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
            this.dataGridView_Cart = new System.Windows.Forms.DataGridView();
            this.iDField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.search_stringToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.search_stringToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView_CourseSections = new System.Windows.Forms.DataGridView();
            this.courseSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.removeFromCartButton = new System.Windows.Forms.Button();
            this.dataGridView_Enrolled = new System.Windows.Forms.DataGridView();
            this.btn_dropCourse = new System.Windows.Forms.Button();
            this.coursesectionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendaryearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlyenrolledDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spgetenrolledBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRegistryDataSet1 = new ClassRegistry.ClassRegistryDataSet1();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spsearchbycoursenameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRegistryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_search_by_course_nameTableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.sp_search_by_course_nameTableAdapter();
            this.spcourseSectionsbycourseIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sp_get_enrolledTableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.sp_get_enrolledTableAdapter();
            this.spcourseSectionsbycourseID1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_course_Sections_by_course_ID1TableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.sp_course_Sections_by_course_ID1TableAdapter();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesectionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendaryearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlyenrolledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_SectionsTableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.Course_SectionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CourseSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Enrolled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetenrolledBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsearchbycoursenameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcourseSectionsbycourseIDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcourseSectionsbycourseID1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Cart
            // 
            this.dataGridView_Cart.AllowUserToAddRows = false;
            this.dataGridView_Cart.AllowUserToDeleteRows = false;
            this.dataGridView_Cart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cart.Location = new System.Drawing.Point(9, 298);
            this.dataGridView_Cart.Name = "dataGridView_Cart";
            this.dataGridView_Cart.ReadOnly = true;
            this.dataGridView_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cart.Size = new System.Drawing.Size(778, 141);
            this.dataGridView_Cart.TabIndex = 1;
            // 
            // iDField
            // 
            this.iDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDField.Location = new System.Drawing.Point(106, 18);
            this.iDField.Name = "iDField";
            this.iDField.Size = new System.Drawing.Size(100, 26);
            this.iDField.TabIndex = 2;
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
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(210, 16);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToCart.Location = new System.Drawing.Point(688, 242);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.btn_addToCart.Size = new System.Drawing.Size(99, 27);
            this.btn_addToCart.TabIndex = 7;
            this.btn_addToCart.Text = "Add To Cart";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cart";
            // 
            // btn_enroll
            // 
            this.btn_enroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enroll.Location = new System.Drawing.Point(655, 445);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.btn_enroll.Size = new System.Drawing.Size(133, 28);
            this.btn_enroll.TabIndex = 9;
            this.btn_enroll.Text = "Enroll to Classes";
            this.btn_enroll.UseVisualStyleBackColor = true;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Schedule";
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.AllowUserToAddRows = false;
            this.dataGridView_Course.AllowUserToDeleteRows = false;
            this.dataGridView_Course.AutoGenerateColumns = false;
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coursenameDataGridViewTextBoxColumn});
            this.dataGridView_Course.DataSource = this.spsearchbycoursenameBindingSource;
            this.dataGridView_Course.Location = new System.Drawing.Point(9, 86);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.ReadOnly = true;
            this.dataGridView_Course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Course.Size = new System.Drawing.Size(169, 150);
            this.dataGridView_Course.TabIndex = 0;
            this.dataGridView_Course.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            // 
            // search_stringToolStripTextBox
            // 
            this.search_stringToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_stringToolStripTextBox.Name = "search_stringToolStripTextBox";
            this.search_stringToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.search_stringToolStripTextBox.TextChanged += new System.EventHandler(this.search_stringToolStripTextBox_TextChanged);
            // 
            // dataGridView_CourseSections
            // 
            this.dataGridView_CourseSections.AllowUserToAddRows = false;
            this.dataGridView_CourseSections.AllowUserToDeleteRows = false;
            this.dataGridView_CourseSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_CourseSections.AutoGenerateColumns = false;
            this.dataGridView_CourseSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CourseSections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.coursesectionIDDataGridViewTextBoxColumn1,
            this.semesterDataGridViewTextBoxColumn,
            this.calendaryearDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.currentlyenrolledDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.calendaryearDataGridViewTextBoxColumn,
            this.timeslotIDDataGridViewTextBoxColumn});
            this.dataGridView_CourseSections.DataSource = this.spcourseSectionsbycourseIDBindingSource;
            this.dataGridView_CourseSections.Location = new System.Drawing.Point(184, 86);
            this.dataGridView_CourseSections.Name = "dataGridView_CourseSections";
            this.dataGridView_CourseSections.ReadOnly = true;
            this.dataGridView_CourseSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CourseSections.Size = new System.Drawing.Size(603, 150);
            this.dataGridView_CourseSections.TabIndex = 12;
            // 
            // courseSectionsBindingSource
            // 
            this.courseSectionsBindingSource.DataMember = "Course_Sections";
            this.courseSectionsBindingSource.DataSource = this.classRegistryDataSet1BindingSource;
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.Location = new System.Drawing.Point(299, 18);
            this.loggedInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(101, 18);
            this.loggedInLabel.TabIndex = 13;
            this.loggedInLabel.Text = "logged in label";
            this.loggedInLabel.Visible = false;
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(209, 16);
            this.logOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(75, 23);
            this.logOut.TabIndex = 14;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Visible = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // removeFromCartButton
            // 
            this.removeFromCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeFromCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromCartButton.Location = new System.Drawing.Point(550, 445);
            this.removeFromCartButton.Name = "removeFromCartButton";
            this.removeFromCartButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.removeFromCartButton.Size = new System.Drawing.Size(99, 28);
            this.removeFromCartButton.TabIndex = 13;
            this.removeFromCartButton.Text = "Remove from Cart";
            this.removeFromCartButton.UseVisualStyleBackColor = true;
            this.removeFromCartButton.Visible = false;
            this.removeFromCartButton.Click += new System.EventHandler(this.removeFromCartButton_Click);
            // 
            // dataGridView_Enrolled
            // 
            this.dataGridView_Enrolled.AllowUserToAddRows = false;
            this.dataGridView_Enrolled.AllowUserToDeleteRows = false;
            this.dataGridView_Enrolled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Enrolled.AutoGenerateColumns = false;
            this.dataGridView_Enrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Enrolled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coursesectionIDDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn1,
            this.semesterDataGridViewTextBoxColumn1,
            this.calendaryearDataGridViewTextBoxColumn1,
            this.capacityDataGridViewTextBoxColumn1,
            this.currentlyenrolledDataGridViewTextBoxColumn1,
            this.scheduledayDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn});
            this.dataGridView_Enrolled.DataSource = this.spgetenrolledBindingSource;
            this.dataGridView_Enrolled.Location = new System.Drawing.Point(9, 503);
            this.dataGridView_Enrolled.Name = "dataGridView_Enrolled";
            this.dataGridView_Enrolled.ReadOnly = true;
            this.dataGridView_Enrolled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Enrolled.Size = new System.Drawing.Size(778, 139);
            this.dataGridView_Enrolled.TabIndex = 14;
            // 
            // btn_dropCourse
            // 
            this.btn_dropCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dropCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dropCourse.Location = new System.Drawing.Point(997, 646);
            this.btn_dropCourse.Name = "btn_dropCourse";
            this.btn_dropCourse.Size = new System.Drawing.Size(133, 31);
            this.btn_dropCourse.TabIndex = 15;
            this.btn_dropCourse.Text = "Drop Course";
            this.btn_dropCourse.UseVisualStyleBackColor = true;
            this.btn_dropCourse.Click += new System.EventHandler(this.btn_dropCourse_Click);
            // 
            // coursesectionIDDataGridViewTextBoxColumn
            // 
            this.coursesectionIDDataGridViewTextBoxColumn.DataPropertyName = "course_section_ID";
            this.coursesectionIDDataGridViewTextBoxColumn.HeaderText = "course_section_ID";
            this.coursesectionIDDataGridViewTextBoxColumn.Name = "coursesectionIDDataGridViewTextBoxColumn";
            this.coursesectionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursenameDataGridViewTextBoxColumn1
            // 
            this.coursenameDataGridViewTextBoxColumn1.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn1.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn1.Name = "coursenameDataGridViewTextBoxColumn1";
            this.coursenameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn1
            // 
            this.semesterDataGridViewTextBoxColumn1.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn1.HeaderText = "semester";
            this.semesterDataGridViewTextBoxColumn1.Name = "semesterDataGridViewTextBoxColumn1";
            this.semesterDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // calendaryearDataGridViewTextBoxColumn1
            // 
            this.calendaryearDataGridViewTextBoxColumn1.DataPropertyName = "calendar_year";
            this.calendaryearDataGridViewTextBoxColumn1.HeaderText = "calendar_year";
            this.calendaryearDataGridViewTextBoxColumn1.Name = "calendaryearDataGridViewTextBoxColumn1";
            this.calendaryearDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn1
            // 
            this.capacityDataGridViewTextBoxColumn1.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn1.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn1.Name = "capacityDataGridViewTextBoxColumn1";
            this.capacityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // currentlyenrolledDataGridViewTextBoxColumn1
            // 
            this.currentlyenrolledDataGridViewTextBoxColumn1.DataPropertyName = "currently_enrolled";
            this.currentlyenrolledDataGridViewTextBoxColumn1.HeaderText = "currently_enrolled";
            this.currentlyenrolledDataGridViewTextBoxColumn1.Name = "currentlyenrolledDataGridViewTextBoxColumn1";
            this.currentlyenrolledDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // scheduledayDataGridViewTextBoxColumn
            // 
            this.scheduledayDataGridViewTextBoxColumn.DataPropertyName = "schedule_day";
            this.scheduledayDataGridViewTextBoxColumn.HeaderText = "schedule_day";
            this.scheduledayDataGridViewTextBoxColumn.Name = "scheduledayDataGridViewTextBoxColumn";
            this.scheduledayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spgetenrolledBindingSource
            // 
            this.spgetenrolledBindingSource.DataMember = "sp_get_enrolled";
            this.spgetenrolledBindingSource.DataSource = this.classRegistryDataSet1;
            // 
            // classRegistryDataSet1
            // 
            this.classRegistryDataSet1.DataSetName = "ClassRegistryDataSet1";
            this.classRegistryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // classRegistryDataSet1BindingSource
            // 
            this.classRegistryDataSet1BindingSource.DataSource = this.classRegistryDataSet1;
            this.classRegistryDataSet1BindingSource.Position = 0;
            // 
            // sp_search_by_course_nameTableAdapter
            // 
            this.sp_search_by_course_nameTableAdapter.ClearBeforeFill = true;
            // 
            // spcourseSectionsbycourseIDBindingSource1
            // 
            this.spcourseSectionsbycourseIDBindingSource1.DataMember = "sp_course_Sections_by_course_ID";
            this.spcourseSectionsbycourseIDBindingSource1.DataSource = this.classRegistryDataSet1;
            // 
            // sp_get_enrolledTableAdapter
            // 
            this.sp_get_enrolledTableAdapter.ClearBeforeFill = true;
            // 
            // spcourseSectionsbycourseID1BindingSource
            // 
            this.btn_dropCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dropCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dropCourse.Location = new System.Drawing.Point(655, 646);
            this.btn_dropCourse.Name = "btn_dropCourse";
            this.btn_dropCourse.Size = new System.Drawing.Size(133, 31);
            this.btn_dropCourse.TabIndex = 15;
            this.btn_dropCourse.Text = "Drop Course";
            this.btn_dropCourse.UseVisualStyleBackColor = true;
            this.btn_dropCourse.Click += new System.EventHandler(this.btn_dropCourse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 687);
            this.Controls.Add(this.btn_dropCourse);
            this.Controls.Add(this.dataGridView_Enrolled);
            this.Controls.Add(this.removeFromCartButton);
            this.Controls.Add(this.dataGridView_CourseSections);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_enroll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iDField);
            this.Controls.Add(this.dataGridView_Cart);
            this.Controls.Add(this.dataGridView_Course);
            this.MinimumSize = new System.Drawing.Size(824, 677);
            this.Name = "Form1";
            this.Text = "Class Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CourseSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Enrolled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetenrolledBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsearchbycoursenameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcourseSectionsbycourseIDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcourseSectionsbycourseID1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Cart;
        private System.Windows.Forms.TextBox iDField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spsearchbycoursenameBindingSource;
        private ClassRegistryDataSet1 classRegistryDataSet1;
        private ClassRegistryDataSet1TableAdapters.sp_search_by_course_nameTableAdapter sp_search_by_course_nameTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel search_stringToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox search_stringToolStripTextBox;
        private System.Windows.Forms.DataGridView dataGridView_CourseSections;
        private System.Windows.Forms.BindingSource classRegistryDataSet1BindingSource;
        private System.Windows.Forms.BindingSource courseSectionsBindingSource;
        private System.Windows.Forms.BindingSource spcourseSectionsbycourseIDBindingSource1;
        private ClassRegistryDataSet1TableAdapters.CartTableAdapter cartTableAdapter;
        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button removeFromCartButton;
        private System.Windows.Forms.DataGridView dataGridView_Enrolled;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesectionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendaryearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentlyenrolledDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduledayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spgetenrolledBindingSource;
        private ClassRegistryDataSet1TableAdapters.sp_get_enrolledTableAdapter sp_get_enrolledTableAdapter;
        private System.Windows.Forms.Button btn_dropCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesectionIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendaryearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentlyenrolledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduledayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource spcourseSectionsbycourseID1BindingSource;
        private ClassRegistryDataSet1TableAdapters.sp_course_Sections_by_course_ID1TableAdapter sp_course_Sections_by_course_ID1TableAdapter;
        private ClassRegistryDataSet1TableAdapters.Course_SectionsTableAdapter course_SectionsTableAdapter;
    }
}

