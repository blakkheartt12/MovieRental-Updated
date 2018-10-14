namespace MovieRental
{
    partial class MainPageView
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
            System.Windows.Forms.Label cUSTOMER_IDLabel;
            System.Windows.Forms.Label cUSTOMER_FNAMELabel;
            System.Windows.Forms.Label cUSTOMER_LNAMELabel;
            System.Windows.Forms.Label cUSTOMER_ADDRESS1Label;
            System.Windows.Forms.Label cUSTOMER_STATELabel;
            System.Windows.Forms.Label cUSTOMER_ZIPLabel;
            System.Windows.Forms.Label cUSTOMER_EMAILLabel;
            System.Windows.Forms.Label sUSPENDEDLabel;
            System.Windows.Forms.Label cityLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishLoadingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFilePanel = new System.Windows.Forms.Panel();
            this.instructionTxtBx = new System.Windows.Forms.RichTextBox();
            this.finishLoadingDataBtn = new System.Windows.Forms.Button();
            this.loadRentalDataBtn = new System.Windows.Forms.Button();
            this.loadMovieDataBtn = new System.Windows.Forms.Button();
            this.loadCustomerBtn = new System.Windows.Forms.Button();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.hideCLBtn = new System.Windows.Forms.Button();
            this.allClientsGrid2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cUSTOMER_INFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIESDataSet = new MovieRental.MOVIESDataSet();
            this.clearAll = new System.Windows.Forms.Button();
            this.updateClientBtn = new System.Windows.Forms.Button();
            this.deletedCheckBx = new System.Windows.Forms.CheckBox();
            this.custCityTxtBx = new System.Windows.Forms.TextBox();
            this.custEmailTxtBx = new System.Windows.Forms.TextBox();
            this.custZipTxtBx = new System.Windows.Forms.TextBox();
            this.stateComboBx = new System.Windows.Forms.ComboBox();
            this.custAddrTxtBx = new System.Windows.Forms.TextBox();
            this.custLNameTxtBx = new System.Windows.Forms.TextBox();
            this.custFNameTxtBx = new System.Windows.Forms.TextBox();
            this.custIDtxtBx = new System.Windows.Forms.TextBox();
            this.movieRentalBtn = new System.Windows.Forms.Button();
            this.allClientBtn = new System.Windows.Forms.Button();
            this.searchNameBtn = new System.Windows.Forms.Button();
            this.searchIDBtn = new System.Windows.Forms.Button();
            this.addClientbtn = new System.Windows.Forms.Button();
            this.cUSTOMER_INFOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cUSTOMER_INFOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cUSTOMER_INFOTableAdapter = new MovieRental.MOVIESDataSetTableAdapters.CUSTOMER_INFOTableAdapter();
            this.tableAdapterManager = new MovieRental.MOVIESDataSetTableAdapters.TableAdapterManager();
            this.mOVIESDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cUSTOMER_IDLabel = new System.Windows.Forms.Label();
            cUSTOMER_FNAMELabel = new System.Windows.Forms.Label();
            cUSTOMER_LNAMELabel = new System.Windows.Forms.Label();
            cUSTOMER_ADDRESS1Label = new System.Windows.Forms.Label();
            cUSTOMER_STATELabel = new System.Windows.Forms.Label();
            cUSTOMER_ZIPLabel = new System.Windows.Forms.Label();
            cUSTOMER_EMAILLabel = new System.Windows.Forms.Label();
            sUSPENDEDLabel = new System.Windows.Forms.Label();
            cityLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.loadFilePanel.SuspendLayout();
            this.mainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allClientsGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMER_INFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMER_INFOBindingNavigator)).BeginInit();
            this.cUSTOMER_INFOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERINFOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cUSTOMER_IDLabel
            // 
            cUSTOMER_IDLabel.AutoSize = true;
            cUSTOMER_IDLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_IDLabel.ForeColor = System.Drawing.Color.White;
            cUSTOMER_IDLabel.Location = new System.Drawing.Point(52, 46);
            cUSTOMER_IDLabel.Name = "cUSTOMER_IDLabel";
            cUSTOMER_IDLabel.Size = new System.Drawing.Size(140, 22);
            cUSTOMER_IDLabel.TabIndex = 0;
            cUSTOMER_IDLabel.Text = "CUSTOMER ID:";
            // 
            // cUSTOMER_FNAMELabel
            // 
            cUSTOMER_FNAMELabel.AutoSize = true;
            cUSTOMER_FNAMELabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_FNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_FNAMELabel.ForeColor = System.Drawing.Color.White;
            cUSTOMER_FNAMELabel.Location = new System.Drawing.Point(69, 92);
            cUSTOMER_FNAMELabel.Name = "cUSTOMER_FNAMELabel";
            cUSTOMER_FNAMELabel.Size = new System.Drawing.Size(123, 22);
            cUSTOMER_FNAMELabel.TabIndex = 2;
            cUSTOMER_FNAMELabel.Text = "FIRST NAME:";
            // 
            // cUSTOMER_LNAMELabel
            // 
            cUSTOMER_LNAMELabel.AutoSize = true;
            cUSTOMER_LNAMELabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_LNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_LNAMELabel.ForeColor = System.Drawing.Color.White;
            cUSTOMER_LNAMELabel.Location = new System.Drawing.Point(470, 95);
            cUSTOMER_LNAMELabel.Name = "cUSTOMER_LNAMELabel";
            cUSTOMER_LNAMELabel.Size = new System.Drawing.Size(117, 22);
            cUSTOMER_LNAMELabel.TabIndex = 4;
            cUSTOMER_LNAMELabel.Text = "LAST NAME:";
            // 
            // cUSTOMER_ADDRESS1Label
            // 
            cUSTOMER_ADDRESS1Label.AutoSize = true;
            cUSTOMER_ADDRESS1Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_ADDRESS1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_ADDRESS1Label.ForeColor = System.Drawing.Color.White;
            cUSTOMER_ADDRESS1Label.Location = new System.Drawing.Point(90, 140);
            cUSTOMER_ADDRESS1Label.Name = "cUSTOMER_ADDRESS1Label";
            cUSTOMER_ADDRESS1Label.Size = new System.Drawing.Size(102, 22);
            cUSTOMER_ADDRESS1Label.TabIndex = 6;
            cUSTOMER_ADDRESS1Label.Text = "ADDRESS:";
            // 
            // cUSTOMER_STATELabel
            // 
            cUSTOMER_STATELabel.AutoSize = true;
            cUSTOMER_STATELabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_STATELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_STATELabel.ForeColor = System.Drawing.Color.White;
            cUSTOMER_STATELabel.Location = new System.Drawing.Point(451, 184);
            cUSTOMER_STATELabel.Name = "cUSTOMER_STATELabel";
            cUSTOMER_STATELabel.Size = new System.Drawing.Size(75, 22);
            cUSTOMER_STATELabel.TabIndex = 8;
            cUSTOMER_STATELabel.Text = "STATE:";
            // 
            // cUSTOMER_ZIPLabel
            // 
            cUSTOMER_ZIPLabel.AutoSize = true;
            cUSTOMER_ZIPLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_ZIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_ZIPLabel.ForeColor = System.Drawing.Color.White;
            cUSTOMER_ZIPLabel.Location = new System.Drawing.Point(654, 184);
            cUSTOMER_ZIPLabel.Name = "cUSTOMER_ZIPLabel";
            cUSTOMER_ZIPLabel.Size = new System.Drawing.Size(42, 22);
            cUSTOMER_ZIPLabel.TabIndex = 10;
            cUSTOMER_ZIPLabel.Text = "ZIP:";
            // 
            // cUSTOMER_EMAILLabel
            // 
            cUSTOMER_EMAILLabel.AutoSize = true;
            cUSTOMER_EMAILLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_EMAILLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cUSTOMER_EMAILLabel.ForeColor = System.Drawing.Color.White;
            cUSTOMER_EMAILLabel.Location = new System.Drawing.Point(27, 223);
            cUSTOMER_EMAILLabel.Name = "cUSTOMER_EMAILLabel";
            cUSTOMER_EMAILLabel.Size = new System.Drawing.Size(165, 22);
            cUSTOMER_EMAILLabel.TabIndex = 12;
            cUSTOMER_EMAILLabel.Text = "E-MAIL ADDRESS:";
            // 
            // sUSPENDEDLabel
            // 
            sUSPENDEDLabel.AutoSize = true;
            sUSPENDEDLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            sUSPENDEDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            sUSPENDEDLabel.ForeColor = System.Drawing.Color.White;
            sUSPENDEDLabel.Location = new System.Drawing.Point(488, 39);
            sUSPENDEDLabel.Name = "sUSPENDEDLabel";
            sUSPENDEDLabel.Size = new System.Drawing.Size(99, 22);
            sUSPENDEDLabel.TabIndex = 14;
            sUSPENDEDLabel.Text = "DELETED:";
            // 
            // cityLbl
            // 
            cityLbl.AutoSize = true;
            cityLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            cityLbl.ForeColor = System.Drawing.Color.White;
            cityLbl.Location = new System.Drawing.Point(136, 184);
            cityLbl.Name = "cityLbl";
            cityLbl.Size = new System.Drawing.Size(56, 22);
            cityLbl.TabIndex = 29;
            cityLbl.Text = "CITY:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.employeeMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInfoToolStripMenuItem1,
            this.rentalInfoToolStripMenuItem1,
            this.rentalDataToolStripMenuItem,
            this.finishLoadingDataToolStripMenuItem});
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadFileToolStripMenuItem.Text = "Load Data File";
            // 
            // customerInfoToolStripMenuItem1
            // 
            this.customerInfoToolStripMenuItem1.Name = "customerInfoToolStripMenuItem1";
            this.customerInfoToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.customerInfoToolStripMenuItem1.Text = "Customer Info";
            this.customerInfoToolStripMenuItem1.Click += new System.EventHandler(this.customerInfoToolStripMenuItem1_Click);
            // 
            // rentalInfoToolStripMenuItem1
            // 
            this.rentalInfoToolStripMenuItem1.Name = "rentalInfoToolStripMenuItem1";
            this.rentalInfoToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.rentalInfoToolStripMenuItem1.Text = "Movie Data";
            this.rentalInfoToolStripMenuItem1.Click += new System.EventHandler(this.rentalInfoToolStripMenuItem1_Click);
            // 
            // rentalDataToolStripMenuItem
            // 
            this.rentalDataToolStripMenuItem.Name = "rentalDataToolStripMenuItem";
            this.rentalDataToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rentalDataToolStripMenuItem.Text = "Rental Data";
            this.rentalDataToolStripMenuItem.Click += new System.EventHandler(this.rentalDataToolStripMenuItem_Click);
            // 
            // finishLoadingDataToolStripMenuItem
            // 
            this.finishLoadingDataToolStripMenuItem.Name = "finishLoadingDataToolStripMenuItem";
            this.finishLoadingDataToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.finishLoadingDataToolStripMenuItem.Text = "Finish Loading Data";
            this.finishLoadingDataToolStripMenuItem.Click += new System.EventHandler(this.finishLoadingDataToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.rentalHistoryToolStripMenuItem});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.clientToolStripMenuItem.Text = "Client List";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.moviesToolStripMenuItem.Text = "Movies List";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // rentalHistoryToolStripMenuItem
            // 
            this.rentalHistoryToolStripMenuItem.Name = "rentalHistoryToolStripMenuItem";
            this.rentalHistoryToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.rentalHistoryToolStripMenuItem.Text = "Rental History";
            this.rentalHistoryToolStripMenuItem.Click += new System.EventHandler(this.rentalHistoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // employeeMenuToolStripMenuItem
            // 
            this.employeeMenuToolStripMenuItem.Name = "employeeMenuToolStripMenuItem";
            this.employeeMenuToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.employeeMenuToolStripMenuItem.Text = "Employee Menu";
            this.employeeMenuToolStripMenuItem.Click += new System.EventHandler(this.employeeMenuToolStripMenuItem_Click);
            // 
            // loadFilePanel
            // 
            this.loadFilePanel.BackColor = System.Drawing.Color.Transparent;
            this.loadFilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadFilePanel.Controls.Add(this.instructionTxtBx);
            this.loadFilePanel.Controls.Add(this.finishLoadingDataBtn);
            this.loadFilePanel.Controls.Add(this.loadRentalDataBtn);
            this.loadFilePanel.Controls.Add(this.loadMovieDataBtn);
            this.loadFilePanel.Controls.Add(this.loadCustomerBtn);
            this.loadFilePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadFilePanel.Location = new System.Drawing.Point(0, 0);
            this.loadFilePanel.Name = "loadFilePanel";
            this.loadFilePanel.Size = new System.Drawing.Size(1346, 833);
            this.loadFilePanel.TabIndex = 1;
            // 
            // instructionTxtBx
            // 
            this.instructionTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.instructionTxtBx.Location = new System.Drawing.Point(37, 32);
            this.instructionTxtBx.Name = "instructionTxtBx";
            this.instructionTxtBx.ReadOnly = true;
            this.instructionTxtBx.Size = new System.Drawing.Size(1176, 354);
            this.instructionTxtBx.TabIndex = 6;
            this.instructionTxtBx.Text = resources.GetString("instructionTxtBx.Text");
            // 
            // finishLoadingDataBtn
            // 
            this.finishLoadingDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishLoadingDataBtn.Location = new System.Drawing.Point(942, 432);
            this.finishLoadingDataBtn.Name = "finishLoadingDataBtn";
            this.finishLoadingDataBtn.Size = new System.Drawing.Size(205, 71);
            this.finishLoadingDataBtn.TabIndex = 9;
            this.finishLoadingDataBtn.Text = "Finish Loading Data";
            this.finishLoadingDataBtn.UseVisualStyleBackColor = true;
            this.finishLoadingDataBtn.Click += new System.EventHandler(this.finishLoadingDataBtn_Click);
            // 
            // loadRentalDataBtn
            // 
            this.loadRentalDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadRentalDataBtn.Location = new System.Drawing.Point(650, 432);
            this.loadRentalDataBtn.Name = "loadRentalDataBtn";
            this.loadRentalDataBtn.Size = new System.Drawing.Size(205, 71);
            this.loadRentalDataBtn.TabIndex = 10;
            this.loadRentalDataBtn.Text = "Load Rental Data";
            this.loadRentalDataBtn.UseVisualStyleBackColor = true;
            this.loadRentalDataBtn.Click += new System.EventHandler(this.loadRentalDataBtn_Click_1);
            // 
            // loadMovieDataBtn
            // 
            this.loadMovieDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMovieDataBtn.Location = new System.Drawing.Point(383, 432);
            this.loadMovieDataBtn.Name = "loadMovieDataBtn";
            this.loadMovieDataBtn.Size = new System.Drawing.Size(205, 71);
            this.loadMovieDataBtn.TabIndex = 8;
            this.loadMovieDataBtn.Text = "Load Movie Data";
            this.loadMovieDataBtn.UseVisualStyleBackColor = true;
            this.loadMovieDataBtn.Click += new System.EventHandler(this.loadRentalDataBtn_Click);
            // 
            // loadCustomerBtn
            // 
            this.loadCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCustomerBtn.Location = new System.Drawing.Point(110, 432);
            this.loadCustomerBtn.Name = "loadCustomerBtn";
            this.loadCustomerBtn.Size = new System.Drawing.Size(205, 71);
            this.loadCustomerBtn.TabIndex = 7;
            this.loadCustomerBtn.Text = "Load Customer Data";
            this.loadCustomerBtn.UseVisualStyleBackColor = true;
            this.loadCustomerBtn.Click += new System.EventHandler(this.loadCustomerBtn_Click);
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.Transparent;
            this.mainPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPnl.Controls.Add(this.hideCLBtn);
            this.mainPnl.Controls.Add(this.allClientsGrid2);
            this.mainPnl.Controls.Add(this.clearAll);
            this.mainPnl.Controls.Add(this.updateClientBtn);
            this.mainPnl.Controls.Add(this.deletedCheckBx);
            this.mainPnl.Controls.Add(this.custCityTxtBx);
            this.mainPnl.Controls.Add(cityLbl);
            this.mainPnl.Controls.Add(this.custEmailTxtBx);
            this.mainPnl.Controls.Add(this.custZipTxtBx);
            this.mainPnl.Controls.Add(this.stateComboBx);
            this.mainPnl.Controls.Add(this.custAddrTxtBx);
            this.mainPnl.Controls.Add(this.custLNameTxtBx);
            this.mainPnl.Controls.Add(this.custFNameTxtBx);
            this.mainPnl.Controls.Add(this.custIDtxtBx);
            this.mainPnl.Controls.Add(this.movieRentalBtn);
            this.mainPnl.Controls.Add(this.allClientBtn);
            this.mainPnl.Controls.Add(this.searchNameBtn);
            this.mainPnl.Controls.Add(this.searchIDBtn);
            this.mainPnl.Controls.Add(this.addClientbtn);
            this.mainPnl.Controls.Add(cUSTOMER_IDLabel);
            this.mainPnl.Controls.Add(cUSTOMER_FNAMELabel);
            this.mainPnl.Controls.Add(cUSTOMER_LNAMELabel);
            this.mainPnl.Controls.Add(cUSTOMER_ADDRESS1Label);
            this.mainPnl.Controls.Add(cUSTOMER_STATELabel);
            this.mainPnl.Controls.Add(cUSTOMER_ZIPLabel);
            this.mainPnl.Controls.Add(cUSTOMER_EMAILLabel);
            this.mainPnl.Controls.Add(sUSPENDEDLabel);
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPnl.Location = new System.Drawing.Point(0, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(1346, 833);
            this.mainPnl.TabIndex = 100;
            this.mainPnl.Visible = false;
            // 
            // hideCLBtn
            // 
            this.hideCLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideCLBtn.Location = new System.Drawing.Point(716, 520);
            this.hideCLBtn.Name = "hideCLBtn";
            this.hideCLBtn.Size = new System.Drawing.Size(171, 79);
            this.hideCLBtn.TabIndex = 14;
            this.hideCLBtn.Text = "HIDE ALL CUSTOMERS";
            this.hideCLBtn.UseVisualStyleBackColor = true;
            this.hideCLBtn.Visible = false;
            this.hideCLBtn.Click += new System.EventHandler(this.hideCLBtn_Click);
            // 
            // allClientsGrid2
            // 
            this.allClientsGrid2.AllowUserToAddRows = false;
            this.allClientsGrid2.AllowUserToDeleteRows = false;
            this.allClientsGrid2.AutoGenerateColumns = false;
            this.allClientsGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allClientsGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.allClientsGrid2.DataSource = this.cUSTOMER_INFOBindingSource;
            this.allClientsGrid2.Location = new System.Drawing.Point(31, 263);
            this.allClientsGrid2.MultiSelect = false;
            this.allClientsGrid2.Name = "allClientsGrid2";
            this.allClientsGrid2.ReadOnly = true;
            this.allClientsGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allClientsGrid2.Size = new System.Drawing.Size(1148, 220);
            this.allClientsGrid2.TabIndex = 99;
            this.allClientsGrid2.TabStop = false;
            this.allClientsGrid2.Visible = false;
            this.allClientsGrid2.SelectionChanged += new System.EventHandler(this.allClientsGrid2_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMER_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CUSTOMER_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CUSTOMER_FNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "CUSTOMER_FNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CUSTOMER_LNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "CUSTOMER_LNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CUSTOMER_ADDRESS1";
            this.dataGridViewTextBoxColumn4.HeaderText = "CUSTOMER_ADDRESS1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CUSTOMER_CITY";
            this.dataGridViewTextBoxColumn5.HeaderText = "CUSTOMER_CITY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CUSTOMER_STATE";
            this.dataGridViewTextBoxColumn6.HeaderText = "CUSTOMER_STATE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CUSTOMER_ZIP";
            this.dataGridViewTextBoxColumn7.HeaderText = "CUSTOMER_ZIP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CUSTOMER_EMAIL";
            this.dataGridViewTextBoxColumn8.HeaderText = "CUSTOMER_EMAIL";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "SUSPENDED";
            this.dataGridViewCheckBoxColumn1.HeaderText = "SUSPENDED";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // cUSTOMER_INFOBindingSource
            // 
            this.cUSTOMER_INFOBindingSource.DataMember = "CUSTOMER_INFO";
            this.cUSTOMER_INFOBindingSource.DataSource = this.mOVIESDataSet;
            // 
            // mOVIESDataSet
            // 
            this.mOVIESDataSet.DataSetName = "MOVIESDataSet";
            this.mOVIESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clearAll
            // 
            this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.Location = new System.Drawing.Point(913, 38);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(171, 79);
            this.clearAll.TabIndex = 16;
            this.clearAll.Text = "CLEAR FORM";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // updateClientBtn
            // 
            this.updateClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateClientBtn.Location = new System.Drawing.Point(513, 520);
            this.updateClientBtn.Name = "updateClientBtn";
            this.updateClientBtn.Size = new System.Drawing.Size(171, 79);
            this.updateClientBtn.TabIndex = 12;
            this.updateClientBtn.Text = "UPDATE CUSTOMER";
            this.updateClientBtn.UseVisualStyleBackColor = true;
            this.updateClientBtn.Click += new System.EventHandler(this.updateClientBtn_Click);
            // 
            // deletedCheckBx
            // 
            this.deletedCheckBx.AutoSize = true;
            this.deletedCheckBx.Location = new System.Drawing.Point(594, 43);
            this.deletedCheckBx.Name = "deletedCheckBx";
            this.deletedCheckBx.Size = new System.Drawing.Size(15, 14);
            this.deletedCheckBx.TabIndex = 9;
            this.deletedCheckBx.UseVisualStyleBackColor = true;
            // 
            // custCityTxtBx
            // 
            this.custCityTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custCityTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCityTxtBx.Location = new System.Drawing.Point(198, 177);
            this.custCityTxtBx.Name = "custCityTxtBx";
            this.custCityTxtBx.Size = new System.Drawing.Size(227, 29);
            this.custCityTxtBx.TabIndex = 5;
            // 
            // custEmailTxtBx
            // 
            this.custEmailTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custEmailTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEmailTxtBx.Location = new System.Drawing.Point(198, 219);
            this.custEmailTxtBx.Name = "custEmailTxtBx";
            this.custEmailTxtBx.Size = new System.Drawing.Size(498, 29);
            this.custEmailTxtBx.TabIndex = 8;
            // 
            // custZipTxtBx
            // 
            this.custZipTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custZipTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custZipTxtBx.Location = new System.Drawing.Point(711, 177);
            this.custZipTxtBx.Name = "custZipTxtBx";
            this.custZipTxtBx.Size = new System.Drawing.Size(227, 29);
            this.custZipTxtBx.TabIndex = 7;
            // 
            // stateComboBx
            // 
            this.stateComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBx.FormattingEnabled = true;
            this.stateComboBx.Items.AddRange(new object[] {
            "",
            "AK",
            "AL",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBx.Location = new System.Drawing.Point(543, 174);
            this.stateComboBx.Name = "stateComboBx";
            this.stateComboBx.Size = new System.Drawing.Size(82, 32);
            this.stateComboBx.TabIndex = 6;
            // 
            // custAddrTxtBx
            // 
            this.custAddrTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custAddrTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddrTxtBx.Location = new System.Drawing.Point(198, 135);
            this.custAddrTxtBx.Name = "custAddrTxtBx";
            this.custAddrTxtBx.Size = new System.Drawing.Size(986, 29);
            this.custAddrTxtBx.TabIndex = 4;
            // 
            // custLNameTxtBx
            // 
            this.custLNameTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custLNameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLNameTxtBx.Location = new System.Drawing.Point(593, 88);
            this.custLNameTxtBx.Name = "custLNameTxtBx";
            this.custLNameTxtBx.Size = new System.Drawing.Size(227, 29);
            this.custLNameTxtBx.TabIndex = 3;
            // 
            // custFNameTxtBx
            // 
            this.custFNameTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custFNameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custFNameTxtBx.Location = new System.Drawing.Point(198, 85);
            this.custFNameTxtBx.Name = "custFNameTxtBx";
            this.custFNameTxtBx.Size = new System.Drawing.Size(227, 29);
            this.custFNameTxtBx.TabIndex = 2;
            // 
            // custIDtxtBx
            // 
            this.custIDtxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.custIDtxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIDtxtBx.Location = new System.Drawing.Point(198, 39);
            this.custIDtxtBx.Name = "custIDtxtBx";
            this.custIDtxtBx.Size = new System.Drawing.Size(227, 29);
            this.custIDtxtBx.TabIndex = 1;
            // 
            // movieRentalBtn
            // 
            this.movieRentalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieRentalBtn.Location = new System.Drawing.Point(716, 630);
            this.movieRentalBtn.Name = "movieRentalBtn";
            this.movieRentalBtn.Size = new System.Drawing.Size(171, 79);
            this.movieRentalBtn.TabIndex = 15;
            this.movieRentalBtn.Text = "RENTAL MENU";
            this.movieRentalBtn.UseVisualStyleBackColor = true;
            this.movieRentalBtn.Click += new System.EventHandler(this.movieRentalBtn_Click);
            // 
            // allClientBtn
            // 
            this.allClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allClientBtn.Location = new System.Drawing.Point(716, 520);
            this.allClientBtn.Name = "allClientBtn";
            this.allClientBtn.Size = new System.Drawing.Size(171, 79);
            this.allClientBtn.TabIndex = 20;
            this.allClientBtn.Text = "SHOW ALL CUSTOMERS";
            this.allClientBtn.UseVisualStyleBackColor = true;
            this.allClientBtn.Click += new System.EventHandler(this.allClientBtn_Click);
            // 
            // searchNameBtn
            // 
            this.searchNameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameBtn.Location = new System.Drawing.Point(513, 624);
            this.searchNameBtn.Name = "searchNameBtn";
            this.searchNameBtn.Size = new System.Drawing.Size(171, 79);
            this.searchNameBtn.TabIndex = 13;
            this.searchNameBtn.Text = "SEARCH BY NAME";
            this.searchNameBtn.UseVisualStyleBackColor = true;
            this.searchNameBtn.Click += new System.EventHandler(this.searchNameBtn_Click);
            // 
            // searchIDBtn
            // 
            this.searchIDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDBtn.Location = new System.Drawing.Point(312, 624);
            this.searchIDBtn.Name = "searchIDBtn";
            this.searchIDBtn.Size = new System.Drawing.Size(171, 79);
            this.searchIDBtn.TabIndex = 11;
            this.searchIDBtn.Text = "SEARCH BY ID";
            this.searchIDBtn.UseVisualStyleBackColor = true;
            this.searchIDBtn.Click += new System.EventHandler(this.searchIDBtn_Click);
            // 
            // addClientbtn
            // 
            this.addClientbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientbtn.Location = new System.Drawing.Point(312, 520);
            this.addClientbtn.Name = "addClientbtn";
            this.addClientbtn.Size = new System.Drawing.Size(171, 79);
            this.addClientbtn.TabIndex = 10;
            this.addClientbtn.Text = "ADD CUSTOMER";
            this.addClientbtn.UseVisualStyleBackColor = true;
            this.addClientbtn.Click += new System.EventHandler(this.addClientbtn_Click);
            // 
            // cUSTOMER_INFOBindingNavigator
            // 
            this.cUSTOMER_INFOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cUSTOMER_INFOBindingNavigator.BindingSource = this.cUSTOMER_INFOBindingSource;
            this.cUSTOMER_INFOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cUSTOMER_INFOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cUSTOMER_INFOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cUSTOMER_INFOBindingNavigatorSaveItem});
            this.cUSTOMER_INFOBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.cUSTOMER_INFOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cUSTOMER_INFOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cUSTOMER_INFOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cUSTOMER_INFOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cUSTOMER_INFOBindingNavigator.Name = "cUSTOMER_INFOBindingNavigator";
            this.cUSTOMER_INFOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cUSTOMER_INFOBindingNavigator.Size = new System.Drawing.Size(1656, 25);
            this.cUSTOMER_INFOBindingNavigator.TabIndex = 6;
            this.cUSTOMER_INFOBindingNavigator.Text = "bindingNavigator1";
            this.cUSTOMER_INFOBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cUSTOMER_INFOBindingNavigatorSaveItem
            // 
            this.cUSTOMER_INFOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cUSTOMER_INFOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cUSTOMER_INFOBindingNavigatorSaveItem.Image")));
            this.cUSTOMER_INFOBindingNavigatorSaveItem.Name = "cUSTOMER_INFOBindingNavigatorSaveItem";
            this.cUSTOMER_INFOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cUSTOMER_INFOBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cUSTOMER_INFOTableAdapter
            // 
            this.cUSTOMER_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMER_INFOTableAdapter = this.cUSTOMER_INFOTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.MOVIE_INFOTableAdapter = null;
            this.tableAdapterManager.RENTALTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MovieRental.MOVIESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mOVIESDataSetBindingSource
            // 
            this.mOVIESDataSetBindingSource.DataSource = this.mOVIESDataSet;
            this.mOVIESDataSetBindingSource.Position = 0;
            // 
            // cUSTOMERINFOBindingSource
            // 
            this.cUSTOMERINFOBindingSource.DataMember = "CUSTOMER_INFO";
            this.cUSTOMERINFOBindingSource.DataSource = this.mOVIESDataSetBindingSource;
            // 
            // MainPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 833);
            this.Controls.Add(this.cUSTOMER_INFOBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.loadFilePanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPageView";
            this.Text = "MovieRenter Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPageView_FormClosing);
            this.Load += new System.EventHandler(this.MainPageView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.loadFilePanel.ResumeLayout(false);
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allClientsGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMER_INFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMER_INFOBindingNavigator)).EndInit();
            this.cUSTOMER_INFOBindingNavigator.ResumeLayout(false);
            this.cUSTOMER_INFOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERINFOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button movieRentalBtn;
        private System.Windows.Forms.Button allClientBtn;
        private System.Windows.Forms.Button searchNameBtn;
        private System.Windows.Forms.Button searchIDBtn;
        private System.Windows.Forms.Button addClientbtn;
        private System.Windows.Forms.Button finishLoadingDataBtn;
        private System.Windows.Forms.Button loadMovieDataBtn;
        private System.Windows.Forms.Button loadCustomerBtn;
        private System.Windows.Forms.RichTextBox instructionTxtBx;
        private System.Windows.Forms.ToolStripMenuItem customerInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rentalInfoToolStripMenuItem1;
        private System.Windows.Forms.Button loadRentalDataBtn;
        private System.Windows.Forms.ToolStripMenuItem rentalDataToolStripMenuItem;
        private System.Windows.Forms.TextBox custEmailTxtBx;
        private System.Windows.Forms.TextBox custZipTxtBx;
        private System.Windows.Forms.ComboBox stateComboBx;
        private System.Windows.Forms.TextBox custAddrTxtBx;
        private System.Windows.Forms.TextBox custLNameTxtBx;
        private System.Windows.Forms.TextBox custFNameTxtBx;
        private System.Windows.Forms.TextBox custIDtxtBx;
        private System.Windows.Forms.CheckBox deletedCheckBx;
        private System.Windows.Forms.TextBox custCityTxtBx;
        private System.Windows.Forms.ToolStripMenuItem finishLoadingDataToolStripMenuItem;
        private MOVIESDataSet mOVIESDataSet;
        private System.Windows.Forms.BindingSource cUSTOMER_INFOBindingSource;
        private MOVIESDataSetTableAdapters.CUSTOMER_INFOTableAdapter cUSTOMER_INFOTableAdapter;
        private MOVIESDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cUSTOMER_INFOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cUSTOMER_INFOBindingNavigatorSaveItem;
        private System.Windows.Forms.Button updateClientBtn;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalHistoryToolStripMenuItem;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.BindingSource cUSTOMERINFOBindingSource;
        private System.Windows.Forms.BindingSource mOVIESDataSetBindingSource;
        private System.Windows.Forms.DataGridView allClientsGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        public System.Windows.Forms.Panel loadFilePanel;
        public System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Button hideCLBtn;
        private System.Windows.Forms.ToolStripMenuItem employeeMenuToolStripMenuItem;
    }
}