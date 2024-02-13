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
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spsearchbycoursenameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRegistryDataSet1 = new ClassRegistry.ClassRegistryDataSet1();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.search_stringToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.search_stringToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView_CourseSections = new System.Windows.Forms.DataGridView();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlyenrolledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendaryearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spcourseSectionsbycourseIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRegistryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_search_by_course_nameTableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.sp_search_by_course_nameTableAdapter();
            this.course_SectionsTableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.Course_SectionsTableAdapter();
            this.sp_course_Sections_by_course_IDTableAdapter = new ClassRegistry.ClassRegistryDataSet1TableAdapters.sp_course_Sections_by_course_IDTableAdapter();
            this.spcourseSectionsbycourseIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.removeFromCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsearchbycoursenameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CourseSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcourseSectionsbycourseIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcourseSectionsbycourseIDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Cart
            // 
            this.dataGridView_Cart.AllowUserToAddRows = false;
            this.dataGridView_Cart.AllowUserToDeleteRows = false;
            this.dataGridView_Cart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cart.Location = new System.Drawing.Point(18, 468);
            this.dataGridView_Cart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Cart.Name = "dataGridView_Cart";
            this.dataGridView_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cart.Size = new System.Drawing.Size(1162, 217);
            this.dataGridView_Cart.TabIndex = 1;
            // 
            // iDField
            // iDField
            // 
            this.iDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDField.Location = new System.Drawing.Point(159, 28);
            this.iDField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iDField.Name = "iDField";
            this.iDField.Size = new System.Drawing.Size(148, 26);
            this.iDField.TabIndex = 2;
            this.iDField.TextChanged += new System.EventHandler(this.iDField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Id:";
            // 
            // loginButton
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(318, 28);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 35);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addToCart.Enabled = false;
            this.btn_addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToCart.Location = new System.Drawing.Point(1032, 377);
            this.btn_addToCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Padding = new System.Windows.Forms.Padding(4, 0, 0, 5);
            this.btn_addToCart.Size = new System.Drawing.Size(148, 42);
            this.btn_addToCart.TabIndex = 7;
            this.btn_addToCart.Text = "Add To Cart";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 432);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cart";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(982, 694);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 5);
            this.button3.Size = new System.Drawing.Size(200, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "Enroll to Classes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 748);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Schedule";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.dataGridView_Course.Location = new System.Drawing.Point(14, 132);
            this.dataGridView_Course.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.ReadOnly = true;
            this.dataGridView_Course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Course.Size = new System.Drawing.Size(254, 231);
            this.dataGridView_Course.TabIndex = 0;
            this.dataGridView_Course.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_stringToolStripLabel,
            this.search_stringToolStripTextBox});
            this.fillToolStrip.Location = new System.Drawing.Point(14, 89);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fillToolStrip.Size = new System.Drawing.Size(276, 25);
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
            this.search_stringToolStripTextBox.Size = new System.Drawing.Size(148, 25);
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
            this.capacityDataGridViewTextBoxColumn,
            this.currentlyenrolledDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.calendaryearDataGridViewTextBoxColumn,
            this.timeslotIDDataGridViewTextBoxColumn});
            this.dataGridView_CourseSections.DataSource = this.spcourseSectionsbycourseIDBindingSource;
            this.dataGridView_CourseSections.Location = new System.Drawing.Point(276, 132);
            this.dataGridView_CourseSections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_CourseSections.Name = "dataGridView_CourseSections";
            this.dataGridView_CourseSections.ReadOnly = true;
            this.dataGridView_CourseSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CourseSections.Size = new System.Drawing.Size(904, 231);
            this.dataGridView_CourseSections.TabIndex = 12;
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
            // timeslotIDDataGridViewTextBoxColumn
            // 
            this.timeslotIDDataGridViewTextBoxColumn.DataPropertyName = "time_slot_ID";
            this.timeslotIDDataGridViewTextBoxColumn.HeaderText = "time_slot_ID";
            this.timeslotIDDataGridViewTextBoxColumn.Name = "timeslotIDDataGridViewTextBoxColumn";
            this.timeslotIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spcourseSectionsbycourseIDBindingSource
            // 
            this.spcourseSectionsbycourseIDBindingSource.DataMember = "sp_course_Sections_by_course_ID";
            this.spcourseSectionsbycourseIDBindingSource.DataSource = this.classRegistryDataSet1BindingSource;
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
            // sp_search_by_course_nameTableAdapter
            // 
            this.sp_search_by_course_nameTableAdapter.ClearBeforeFill = true;
            // 
            // course_SectionsTableAdapter
            // 
            this.course_SectionsTableAdapter.ClearBeforeFill = true;
            // 
            // sp_course_Sections_by_course_IDTableAdapter
            // 
            this.sp_course_Sections_by_course_IDTableAdapter.ClearBeforeFill = true;
            // 
            // spcourseSectionsbycourseIDBindingSource1
            // 
            this.spcourseSectionsbycourseIDBindingSource1.DataMember = "sp_course_Sections_by_course_ID";
            this.spcourseSectionsbycourseIDBindingSource1.DataSource = this.classRegistryDataSet1;
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.Location = new System.Drawing.Point(304, 23);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(75, 13);
            this.loggedInLabel.TabIndex = 13;
            this.loggedInLabel.Text = "logged in label";
            this.loggedInLabel.Visible = false;
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(665, 13);
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
            this.removeFromCartButton.Enabled = false;
            this.removeFromCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromCartButton.Location = new System.Drawing.Point(1032, 421);
            this.removeFromCartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeFromCartButton.Name = "removeFromCartButton";
            this.removeFromCartButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 5);
            this.removeFromCartButton.Size = new System.Drawing.Size(148, 42);
            this.removeFromCartButton.TabIndex = 13;
            this.removeFromCartButton.Text = "Remove from Cart";
            this.removeFromCartButton.UseVisualStyleBackColor = true;
            this.removeFromCartButton.Click += new System.EventHandler(this.removeFromCartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 982);
            this.Controls.Add(this.removeFromCartButton);
            this.Controls.Add(this.dataGridView_CourseSections);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iDField);
            this.Controls.Add(this.iDField);
            this.Controls.Add(this.dataGridView_Cart);
            this.Controls.Add(this.dataGridView_Course);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1228, 1021);
            this.Name = "Form1";
            this.Text = "Class Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsearchbycoursenameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsearchbycoursenameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CourseSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcourseSectionsbycourseIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegistryDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcourseSectionsbycourseIDBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button button3;
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
        private ClassRegistryDataSet1TableAdapters.Course_SectionsTableAdapter course_SectionsTableAdapter;
        private System.Windows.Forms.BindingSource spcourseSectionsbycourseIDBindingSource;
        private ClassRegistryDataSet1TableAdapters.sp_course_Sections_by_course_IDTableAdapter sp_course_Sections_by_course_IDTableAdapter;
        private System.Windows.Forms.BindingSource spcourseSectionsbycourseIDBindingSource1;
        private ClassRegistryDataSet1TableAdapters.CartTableAdapter cartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentlyenrolledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendaryearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeslotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button removeFromCartButton;
    }
}

