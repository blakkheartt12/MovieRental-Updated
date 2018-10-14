namespace MovieRental
{
    partial class Employee
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
            System.Windows.Forms.Label cUSTOMER_FNAMELabel;
            System.Windows.Forms.Label cUSTOMER_LNAMELabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empLNTxtBx = new System.Windows.Forms.TextBox();
            this.empFNTxtBx = new System.Windows.Forms.TextBox();
            this.updateEmpBtn = new System.Windows.Forms.Button();
            this.addEmpbtn = new System.Windows.Forms.Button();
            this.newPW1TxtBx = new System.Windows.Forms.TextBox();
            this.oldPWTxtBx = new System.Windows.Forms.TextBox();
            this.newPW2TxtBx = new System.Windows.Forms.TextBox();
            this.answerTxtBx = new System.Windows.Forms.TextBox();
            this.secretQTxtBx = new System.Windows.Forms.ComboBox();
            this.empIDTxtBx = new System.Windows.Forms.TextBox();
            this.mR2Btn = new System.Windows.Forms.Button();
            this.cM2Btn = new System.Windows.Forms.Button();
            this.employeeTableAdapter1 = new MovieRental.MOVIESDataSetTableAdapters.EMPLOYEETableAdapter();
            this.mOVIESDataSet = new MovieRental.MOVIESDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.allEmpGrid = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEELNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empClearBtn = new System.Windows.Forms.Button();
            this.oldPW2TxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            cUSTOMER_FNAMELabel = new System.Windows.Forms.Label();
            cUSTOMER_LNAMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cUSTOMER_FNAMELabel
            // 
            cUSTOMER_FNAMELabel.AutoSize = true;
            cUSTOMER_FNAMELabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_FNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_FNAMELabel.ForeColor = System.Drawing.Color.White;
            cUSTOMER_FNAMELabel.Location = new System.Drawing.Point(51, 96);
            cUSTOMER_FNAMELabel.Name = "cUSTOMER_FNAMELabel";
            cUSTOMER_FNAMELabel.Size = new System.Drawing.Size(123, 22);
            cUSTOMER_FNAMELabel.TabIndex = 25;
            cUSTOMER_FNAMELabel.Text = "FIRST NAME:";
            // 
            // cUSTOMER_LNAMELabel
            // 
            cUSTOMER_LNAMELabel.AutoSize = true;
            cUSTOMER_LNAMELabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_LNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_LNAMELabel.ForeColor = System.Drawing.Color.White;
            cUSTOMER_LNAMELabel.Location = new System.Drawing.Point(57, 136);
            cUSTOMER_LNAMELabel.Name = "cUSTOMER_LNAMELabel";
            cUSTOMER_LNAMELabel.Size = new System.Drawing.Size(117, 22);
            cUSTOMER_LNAMELabel.TabIndex = 26;
            cUSTOMER_LNAMELabel.Text = "LAST NAME:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(458, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 22);
            label1.TabIndex = 35;
            label1.Text = "OLD PASSWORD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(453, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(167, 22);
            label2.TabIndex = 36;
            label2.Text = "NEW PASSWORD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(422, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(198, 22);
            label3.TabIndex = 39;
            label3.Text = "RETYPE PASSWORD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(433, 165);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(188, 22);
            label4.TabIndex = 41;
            label4.Text = "SECRET QUESTION:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(525, 206);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 22);
            label5.TabIndex = 43;
            label5.Text = "ANSWER:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(39, 61);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(135, 22);
            label6.TabIndex = 46;
            label6.Text = "EMPLOYEE ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // empLNTxtBx
            // 
            this.empLNTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.empLNTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLNTxtBx.Location = new System.Drawing.Point(180, 129);
            this.empLNTxtBx.Name = "empLNTxtBx";
            this.empLNTxtBx.Size = new System.Drawing.Size(227, 29);
            this.empLNTxtBx.TabIndex = 2;
            // 
            // empFNTxtBx
            // 
            this.empFNTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.empFNTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empFNTxtBx.Location = new System.Drawing.Point(180, 89);
            this.empFNTxtBx.Name = "empFNTxtBx";
            this.empFNTxtBx.Size = new System.Drawing.Size(227, 29);
            this.empFNTxtBx.TabIndex = 1;
            // 
            // updateEmpBtn
            // 
            this.updateEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmpBtn.Location = new System.Drawing.Point(381, 616);
            this.updateEmpBtn.Name = "updateEmpBtn";
            this.updateEmpBtn.Size = new System.Drawing.Size(171, 79);
            this.updateEmpBtn.TabIndex = 10;
            this.updateEmpBtn.Text = "CHANGE PASSWORD";
            this.updateEmpBtn.UseVisualStyleBackColor = true;
            this.updateEmpBtn.Click += new System.EventHandler(this.updateEmpBtn_Click);
            // 
            // addEmpbtn
            // 
            this.addEmpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpbtn.Location = new System.Drawing.Point(3, 616);
            this.addEmpbtn.Name = "addEmpbtn";
            this.addEmpbtn.Size = new System.Drawing.Size(171, 79);
            this.addEmpbtn.TabIndex = 8;
            this.addEmpbtn.Text = "ADD EMPLOYEE";
            this.addEmpbtn.UseVisualStyleBackColor = true;
            this.addEmpbtn.Click += new System.EventHandler(this.addEmpbtn_Click);
            // 
            // newPW1TxtBx
            // 
            this.newPW1TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPW1TxtBx.Location = new System.Drawing.Point(626, 87);
            this.newPW1TxtBx.Name = "newPW1TxtBx";
            this.newPW1TxtBx.PasswordChar = '*';
            this.newPW1TxtBx.Size = new System.Drawing.Size(369, 29);
            this.newPW1TxtBx.TabIndex = 4;
            // 
            // oldPWTxtBx
            // 
            this.oldPWTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPWTxtBx.Location = new System.Drawing.Point(626, 54);
            this.oldPWTxtBx.Name = "oldPWTxtBx";
            this.oldPWTxtBx.PasswordChar = '*';
            this.oldPWTxtBx.Size = new System.Drawing.Size(369, 29);
            this.oldPWTxtBx.TabIndex = 3;
            // 
            // newPW2TxtBx
            // 
            this.newPW2TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPW2TxtBx.Location = new System.Drawing.Point(626, 122);
            this.newPW2TxtBx.Name = "newPW2TxtBx";
            this.newPW2TxtBx.PasswordChar = '*';
            this.newPW2TxtBx.Size = new System.Drawing.Size(369, 29);
            this.newPW2TxtBx.TabIndex = 5;
            // 
            // answerTxtBx
            // 
            this.answerTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTxtBx.Location = new System.Drawing.Point(625, 199);
            this.answerTxtBx.Name = "answerTxtBx";
            this.answerTxtBx.Size = new System.Drawing.Size(369, 29);
            this.answerTxtBx.TabIndex = 7;
            // 
            // secretQTxtBx
            // 
            this.secretQTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.secretQTxtBx.FormattingEnabled = true;
            this.secretQTxtBx.Items.AddRange(new object[] {
            "",
            "What is your favorite color?",
            "Where did you go to elementary?",
            "What is your favorite food?"});
            this.secretQTxtBx.Location = new System.Drawing.Point(626, 161);
            this.secretQTxtBx.Name = "secretQTxtBx";
            this.secretQTxtBx.Size = new System.Drawing.Size(368, 32);
            this.secretQTxtBx.TabIndex = 6;
            // 
            // empIDTxtBx
            // 
            this.empIDTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.empIDTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDTxtBx.Location = new System.Drawing.Point(180, 54);
            this.empIDTxtBx.Name = "empIDTxtBx";
            this.empIDTxtBx.ReadOnly = true;
            this.empIDTxtBx.Size = new System.Drawing.Size(227, 29);
            this.empIDTxtBx.TabIndex = 47;
            this.empIDTxtBx.TabStop = false;
            // 
            // mR2Btn
            // 
            this.mR2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mR2Btn.Location = new System.Drawing.Point(583, 616);
            this.mR2Btn.Name = "mR2Btn";
            this.mR2Btn.Size = new System.Drawing.Size(171, 79);
            this.mR2Btn.TabIndex = 11;
            this.mR2Btn.Text = "RENTAL MENU";
            this.mR2Btn.UseVisualStyleBackColor = true;
            this.mR2Btn.Click += new System.EventHandler(this.mR2Btn_Click);
            // 
            // cM2Btn
            // 
            this.cM2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.cM2Btn.Location = new System.Drawing.Point(792, 616);
            this.cM2Btn.Name = "cM2Btn";
            this.cM2Btn.Size = new System.Drawing.Size(171, 79);
            this.cM2Btn.TabIndex = 12;
            this.cM2Btn.Text = "CUSTOMER MENU";
            this.cM2Btn.UseVisualStyleBackColor = true;
            this.cM2Btn.Click += new System.EventHandler(this.cM2Btn_Click);
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // mOVIESDataSet
            // 
            this.mOVIESDataSet.DataSetName = "MOVIESDataSet";
            this.mOVIESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 79);
            this.button1.TabIndex = 9;
            this.button1.Text = "DELETE EMPLOYEE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allEmpGrid
            // 
            this.allEmpGrid.AllowUserToAddRows = false;
            this.allEmpGrid.AllowUserToDeleteRows = false;
            this.allEmpGrid.AutoGenerateColumns = false;
            this.allEmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allEmpGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.eMPLOYEEFNAMEDataGridViewTextBoxColumn,
            this.eMPLOYEELNAMEDataGridViewTextBoxColumn,
            this.PASSWORD});
            this.allEmpGrid.DataSource = this.eMPLOYEEBindingSource1;
            this.allEmpGrid.Location = new System.Drawing.Point(180, 290);
            this.allEmpGrid.Name = "allEmpGrid";
            this.allEmpGrid.ReadOnly = true;
            this.allEmpGrid.Size = new System.Drawing.Size(688, 150);
            this.allEmpGrid.TabIndex = 51;
            this.allEmpGrid.TabStop = false;
            this.allEmpGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allEmpGrid_CellClick);
            this.allEmpGrid.SelectionChanged += new System.EventHandler(this.allEmpGrid_SelectionChanged);
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMPLOYEEFNAMEDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEFNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMPLOYEEFNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_FNAME";
            this.eMPLOYEEFNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.eMPLOYEEFNAMEDataGridViewTextBoxColumn.Name = "eMPLOYEEFNAMEDataGridViewTextBoxColumn";
            this.eMPLOYEEFNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMPLOYEELNAMEDataGridViewTextBoxColumn
            // 
            this.eMPLOYEELNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMPLOYEELNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_LNAME";
            this.eMPLOYEELNAMEDataGridViewTextBoxColumn.HeaderText = "LAST NAME";
            this.eMPLOYEELNAMEDataGridViewTextBoxColumn.Name = "eMPLOYEELNAMEDataGridViewTextBoxColumn";
            this.eMPLOYEELNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "PASSWORD";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            this.PASSWORD.Visible = false;
            // 
            // eMPLOYEEBindingSource1
            // 
            this.eMPLOYEEBindingSource1.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource1.DataSource = this.mOVIESDataSet;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.mOVIESDataSet;
            // 
            // empClearBtn
            // 
            this.empClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empClearBtn.Location = new System.Drawing.Point(992, 616);
            this.empClearBtn.Name = "empClearBtn";
            this.empClearBtn.Size = new System.Drawing.Size(171, 79);
            this.empClearBtn.TabIndex = 13;
            this.empClearBtn.Text = "CLEAR FORM";
            this.empClearBtn.UseVisualStyleBackColor = true;
            this.empClearBtn.Click += new System.EventHandler(this.empClearBtn_Click);
            // 
            // oldPW2TxtBx
            // 
            this.oldPW2TxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.oldPW2TxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "PASSWORD", true));
            this.oldPW2TxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.eMPLOYEEBindingSource, "PASSWORD", true));
            this.oldPW2TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPW2TxtBx.Location = new System.Drawing.Point(626, 238);
            this.oldPW2TxtBx.Name = "oldPW2TxtBx";
            this.oldPW2TxtBx.Size = new System.Drawing.Size(369, 29);
            this.oldPW2TxtBx.TabIndex = 54;
            this.oldPW2TxtBx.TabStop = false;
            this.oldPW2TxtBx.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(682, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Please select an employee from the list above to delete or change the password.";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1346, 833);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.oldPW2TxtBx);
            this.Controls.Add(this.empClearBtn);
            this.Controls.Add(this.allEmpGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cM2Btn);
            this.Controls.Add(this.mR2Btn);
            this.Controls.Add(this.empIDTxtBx);
            this.Controls.Add(label6);
            this.Controls.Add(this.secretQTxtBx);
            this.Controls.Add(this.answerTxtBx);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.newPW2TxtBx);
            this.Controls.Add(label3);
            this.Controls.Add(this.newPW1TxtBx);
            this.Controls.Add(this.oldPWTxtBx);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.updateEmpBtn);
            this.Controls.Add(this.addEmpbtn);
            this.Controls.Add(this.empLNTxtBx);
            this.Controls.Add(this.empFNTxtBx);
            this.Controls.Add(cUSTOMER_FNAMELabel);
            this.Controls.Add(cUSTOMER_LNAMELabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee";
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox empLNTxtBx;
        private System.Windows.Forms.TextBox empFNTxtBx;
        private System.Windows.Forms.Button updateEmpBtn;
        private System.Windows.Forms.Button addEmpbtn;
        private System.Windows.Forms.TextBox newPW1TxtBx;
        private System.Windows.Forms.TextBox oldPWTxtBx;
        private System.Windows.Forms.TextBox newPW2TxtBx;
        private System.Windows.Forms.TextBox answerTxtBx;
        private System.Windows.Forms.ComboBox secretQTxtBx;
        private System.Windows.Forms.TextBox empIDTxtBx;
        private System.Windows.Forms.Button mR2Btn;
        private System.Windows.Forms.Button cM2Btn;
        private MOVIESDataSetTableAdapters.EMPLOYEETableAdapter employeeTableAdapter1;
        private MOVIESDataSet mOVIESDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView allEmpGrid;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private System.Windows.Forms.Button empClearBtn;
        private System.Windows.Forms.TextBox oldPW2TxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEELNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.Label label7;
    }
}