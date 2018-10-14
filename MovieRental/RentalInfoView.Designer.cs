namespace MovieRental
{
    partial class rentForm
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
            System.Windows.Forms.Label movie_IDLabel;
            System.Windows.Forms.Label cUSTOMER_IDLabel;
            System.Windows.Forms.Label dATE_RENTEDLabel;
            System.Windows.Forms.Label dATE_RETURNEDLabel;
            System.Windows.Forms.Label movieTitleLbl;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentForm));
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.rentBtn = new System.Windows.Forms.Button();
            this.returnMovieBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.customerMenuBtn = new System.Windows.Forms.Button();
            this.rentedChkBx = new System.Windows.Forms.CheckBox();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.movie_IDTextBox = new System.Windows.Forms.TextBox();
            this.movieTitleTextBx = new System.Windows.Forms.TextBox();
            this.newdateRentedTxtBx = new System.Windows.Forms.TextBox();
            this.dateReturnedTextBx = new System.Windows.Forms.TextBox();
            this.clearFormBtn = new System.Windows.Forms.Button();
            this.rENTALBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.rENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIESDataSet = new MovieRental.MOVIESDataSet();
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
            this.rENTALBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rentedOnlyBtn = new System.Windows.Forms.Button();
            this.rentalHistoryBtn = new System.Windows.Forms.Button();
            this.mOVIEINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIESDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIESDataSet1 = new MovieRental.MOVIESDataSet();
            this.rentalHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.rENTALBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMovies = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mOVIE_INFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTALTableAdapter = new MovieRental.MOVIESDataSetTableAdapters.RENTALTableAdapter();
            this.tableAdapterManager = new MovieRental.MOVIESDataSetTableAdapters.TableAdapterManager();
            this.mOVIE_INFOTableAdapter = new MovieRental.MOVIESDataSetTableAdapters.MOVIE_INFOTableAdapter();
            this.mOVIE_INFOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentedOnly = new System.Windows.Forms.DataGridView();
            this.showMovie2Btn = new System.Windows.Forms.Button();
            this.showMovie3Btn = new System.Windows.Forms.Button();
            this.hideMovieBtn = new System.Windows.Forms.Button();
            movie_IDLabel = new System.Windows.Forms.Label();
            cUSTOMER_IDLabel = new System.Windows.Forms.Label();
            dATE_RENTEDLabel = new System.Windows.Forms.Label();
            dATE_RETURNEDLabel = new System.Windows.Forms.Label();
            movieTitleLbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingNavigator)).BeginInit();
            this.rENTALBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIE_INFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIE_INFOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedOnly)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_IDLabel
            // 
            movie_IDLabel.AutoSize = true;
            movie_IDLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            movie_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            movie_IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            movie_IDLabel.Location = new System.Drawing.Point(72, 109);
            movie_IDLabel.Name = "movie_IDLabel";
            movie_IDLabel.Size = new System.Drawing.Size(98, 24);
            movie_IDLabel.TabIndex = 1;
            movie_IDLabel.Text = "MOVIE ID:";
            // 
            // cUSTOMER_IDLabel
            // 
            cUSTOMER_IDLabel.AutoSize = true;
            cUSTOMER_IDLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cUSTOMER_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cUSTOMER_IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cUSTOMER_IDLabel.Location = new System.Drawing.Point(26, 63);
            cUSTOMER_IDLabel.Name = "cUSTOMER_IDLabel";
            cUSTOMER_IDLabel.Size = new System.Drawing.Size(144, 24);
            cUSTOMER_IDLabel.TabIndex = 7;
            cUSTOMER_IDLabel.Text = "CUSTOMER ID:";
            // 
            // dATE_RENTEDLabel
            // 
            dATE_RENTEDLabel.AutoSize = true;
            dATE_RENTEDLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dATE_RENTEDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dATE_RENTEDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dATE_RENTEDLabel.Location = new System.Drawing.Point(21, 199);
            dATE_RENTEDLabel.Name = "dATE_RENTEDLabel";
            dATE_RENTEDLabel.Size = new System.Drawing.Size(149, 24);
            dATE_RENTEDLabel.TabIndex = 9;
            dATE_RENTEDLabel.Text = "DATE RENTED:";
            // 
            // dATE_RETURNEDLabel
            // 
            dATE_RETURNEDLabel.AutoSize = true;
            dATE_RETURNEDLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dATE_RETURNEDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dATE_RETURNEDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dATE_RETURNEDLabel.Location = new System.Drawing.Point(410, 199);
            dATE_RETURNEDLabel.Name = "dATE_RETURNEDLabel";
            dATE_RETURNEDLabel.Size = new System.Drawing.Size(175, 24);
            dATE_RETURNEDLabel.TabIndex = 11;
            dATE_RETURNEDLabel.Text = "DATE RETURNED:";
            // 
            // movieTitleLbl
            // 
            movieTitleLbl.AutoSize = true;
            movieTitleLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            movieTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            movieTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            movieTitleLbl.Location = new System.Drawing.Point(38, 159);
            movieTitleLbl.Name = "movieTitleLbl";
            movieTitleLbl.Size = new System.Drawing.Size(132, 24);
            movieTitleLbl.TabIndex = 3;
            movieTitleLbl.Text = "MOVIE TITLE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(410, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 24);
            label1.TabIndex = 21;
            label1.Text = "RENTED:";
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.addMovieBtn.Location = new System.Drawing.Point(70, 682);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(191, 68);
            this.addMovieBtn.TabIndex = 13;
            this.addMovieBtn.Text = "ADD MOVIE";
            this.addMovieBtn.UseVisualStyleBackColor = true;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // rentBtn
            // 
            this.rentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.rentBtn.Location = new System.Drawing.Point(268, 682);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(191, 68);
            this.rentBtn.TabIndex = 14;
            this.rentBtn.Text = "RENT MOVIE";
            this.rentBtn.UseVisualStyleBackColor = true;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click_1);
            // 
            // returnMovieBtn
            // 
            this.returnMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.returnMovieBtn.Location = new System.Drawing.Point(463, 682);
            this.returnMovieBtn.Name = "returnMovieBtn";
            this.returnMovieBtn.Size = new System.Drawing.Size(191, 68);
            this.returnMovieBtn.TabIndex = 15;
            this.returnMovieBtn.Text = "RETURN MOVIE";
            this.returnMovieBtn.UseVisualStyleBackColor = true;
            this.returnMovieBtn.Click += new System.EventHandler(this.returnMovieBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.showAllBtn.Location = new System.Drawing.Point(660, 682);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(191, 68);
            this.showAllBtn.TabIndex = 16;
            this.showAllBtn.Text = "SHOW  ALL MOVIES";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // customerMenuBtn
            // 
            this.customerMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.customerMenuBtn.Location = new System.Drawing.Point(857, 682);
            this.customerMenuBtn.Name = "customerMenuBtn";
            this.customerMenuBtn.Size = new System.Drawing.Size(191, 68);
            this.customerMenuBtn.TabIndex = 17;
            this.customerMenuBtn.Text = "CUSTOMER MENU";
            this.customerMenuBtn.UseVisualStyleBackColor = true;
            this.customerMenuBtn.Click += new System.EventHandler(this.customerMenuBtn_Click);
            // 
            // rentedChkBx
            // 
            this.rentedChkBx.BackColor = System.Drawing.Color.Transparent;
            this.rentedChkBx.Location = new System.Drawing.Point(514, 63);
            this.rentedChkBx.Name = "rentedChkBx";
            this.rentedChkBx.Size = new System.Drawing.Size(30, 30);
            this.rentedChkBx.TabIndex = 20;
            this.rentedChkBx.UseVisualStyleBackColor = false;
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.customer_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.customer_IDTextBox.Location = new System.Drawing.Point(176, 60);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.Size = new System.Drawing.Size(216, 29);
            this.customer_IDTextBox.TabIndex = 22;
            // 
            // movie_IDTextBox
            // 
            this.movie_IDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.movie_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.movie_IDTextBox.Location = new System.Drawing.Point(176, 106);
            this.movie_IDTextBox.Name = "movie_IDTextBox";
            this.movie_IDTextBox.Size = new System.Drawing.Size(216, 29);
            this.movie_IDTextBox.TabIndex = 23;
            // 
            // movieTitleTextBx
            // 
            this.movieTitleTextBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.movieTitleTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.movieTitleTextBx.Location = new System.Drawing.Point(176, 154);
            this.movieTitleTextBx.Name = "movieTitleTextBx";
            this.movieTitleTextBx.Size = new System.Drawing.Size(872, 29);
            this.movieTitleTextBx.TabIndex = 24;
            // 
            // newdateRentedTxtBx
            // 
            this.newdateRentedTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.newdateRentedTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.newdateRentedTxtBx.Location = new System.Drawing.Point(176, 194);
            this.newdateRentedTxtBx.Name = "newdateRentedTxtBx";
            this.newdateRentedTxtBx.Size = new System.Drawing.Size(216, 29);
            this.newdateRentedTxtBx.TabIndex = 25;
            // 
            // dateReturnedTextBx
            // 
            this.dateReturnedTextBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dateReturnedTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateReturnedTextBx.Location = new System.Drawing.Point(591, 194);
            this.dateReturnedTextBx.Name = "dateReturnedTextBx";
            this.dateReturnedTextBx.Size = new System.Drawing.Size(216, 29);
            this.dateReturnedTextBx.TabIndex = 26;
            // 
            // clearFormBtn
            // 
            this.clearFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.clearFormBtn.Location = new System.Drawing.Point(838, 33);
            this.clearFormBtn.Name = "clearFormBtn";
            this.clearFormBtn.Size = new System.Drawing.Size(191, 68);
            this.clearFormBtn.TabIndex = 27;
            this.clearFormBtn.Text = "CLEAR FORM";
            this.clearFormBtn.UseVisualStyleBackColor = true;
            this.clearFormBtn.Click += new System.EventHandler(this.clearFormBtn_Click);
            // 
            // rENTALBindingNavigator
            // 
            this.rENTALBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rENTALBindingNavigator.BindingSource = this.rENTALBindingSource;
            this.rENTALBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rENTALBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rENTALBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rENTALBindingNavigatorSaveItem});
            this.rENTALBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rENTALBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rENTALBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rENTALBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rENTALBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rENTALBindingNavigator.Name = "rENTALBindingNavigator";
            this.rENTALBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rENTALBindingNavigator.Size = new System.Drawing.Size(1199, 25);
            this.rENTALBindingNavigator.TabIndex = 28;
            this.rENTALBindingNavigator.Text = "bindingNavigator1";
            this.rENTALBindingNavigator.Visible = false;
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
            // rENTALBindingSource
            // 
            this.rENTALBindingSource.DataMember = "RENTAL";
            this.rENTALBindingSource.DataSource = this.mOVIESDataSet;
            // 
            // mOVIESDataSet
            // 
            this.mOVIESDataSet.DataSetName = "MOVIESDataSet";
            this.mOVIESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // rENTALBindingNavigatorSaveItem
            // 
            this.rENTALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rENTALBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rENTALBindingNavigatorSaveItem.Image")));
            this.rENTALBindingNavigatorSaveItem.Name = "rENTALBindingNavigatorSaveItem";
            this.rENTALBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rENTALBindingNavigatorSaveItem.Text = "Save Data";
            this.rENTALBindingNavigatorSaveItem.Click += new System.EventHandler(this.rENTALBindingNavigatorSaveItem_Click);
            // 
            // rentedOnlyBtn
            // 
            this.rentedOnlyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.rentedOnlyBtn.Location = new System.Drawing.Point(70, 514);
            this.rentedOnlyBtn.Name = "rentedOnlyBtn";
            this.rentedOnlyBtn.Size = new System.Drawing.Size(191, 68);
            this.rentedOnlyBtn.TabIndex = 29;
            this.rentedOnlyBtn.Text = "SHOW RENTED ONLY";
            this.rentedOnlyBtn.UseVisualStyleBackColor = true;
            this.rentedOnlyBtn.Visible = false;
            this.rentedOnlyBtn.Click += new System.EventHandler(this.rentedOnlyBtn_Click);
            // 
            // rentalHistoryBtn
            // 
            this.rentalHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.rentalHistoryBtn.Location = new System.Drawing.Point(463, 514);
            this.rentalHistoryBtn.Name = "rentalHistoryBtn";
            this.rentalHistoryBtn.Size = new System.Drawing.Size(191, 68);
            this.rentalHistoryBtn.TabIndex = 30;
            this.rentalHistoryBtn.Text = "SHOW RENTAL HISTORY";
            this.rentalHistoryBtn.UseVisualStyleBackColor = true;
            this.rentalHistoryBtn.Visible = false;
            this.rentalHistoryBtn.Click += new System.EventHandler(this.rentalHistoryBtn_Click_1);
            // 
            // mOVIEINFOBindingSource
            // 
            this.mOVIEINFOBindingSource.DataMember = "MOVIE_INFO";
            this.mOVIEINFOBindingSource.DataSource = this.mOVIESDataSet1BindingSource;
            // 
            // mOVIESDataSet1BindingSource
            // 
            this.mOVIESDataSet1BindingSource.DataSource = this.mOVIESDataSet1;
            this.mOVIESDataSet1BindingSource.Position = 0;
            // 
            // mOVIESDataSet1
            // 
            this.mOVIESDataSet1.DataSetName = "MOVIESDataSet";
            this.mOVIESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentalHistoryDataGrid
            // 
            this.rentalHistoryDataGrid.AllowUserToAddRows = false;
            this.rentalHistoryDataGrid.AllowUserToDeleteRows = false;
            this.rentalHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalHistoryDataGrid.Location = new System.Drawing.Point(76, 237);
            this.rentalHistoryDataGrid.Name = "rentalHistoryDataGrid";
            this.rentalHistoryDataGrid.ReadOnly = true;
            this.rentalHistoryDataGrid.Size = new System.Drawing.Size(966, 256);
            this.rentalHistoryDataGrid.TabIndex = 34;
            this.rentalHistoryDataGrid.Visible = false;
            // 
            // rENTALBindingSource1
            // 
            this.rENTALBindingSource1.DataMember = "RENTAL";
            this.rENTALBindingSource1.DataSource = this.mOVIESDataSet1BindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.employeeMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.rentalHistoryToolStripMenuItem});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // allMovies
            // 
            this.allMovies.AllowUserToAddRows = false;
            this.allMovies.AllowUserToDeleteRows = false;
            this.allMovies.AutoGenerateColumns = false;
            this.allMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.allMovies.DataSource = this.mOVIE_INFOBindingSource;
            this.allMovies.Location = new System.Drawing.Point(76, 237);
            this.allMovies.Name = "allMovies";
            this.allMovies.ReadOnly = true;
            this.allMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allMovies.Size = new System.Drawing.Size(972, 256);
            this.allMovies.TabIndex = 36;
            this.allMovies.Visible = false;
            this.allMovies.SelectionChanged += new System.EventHandler(this.allMovies_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MOVIE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MOVIE ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MOVIE_TITLE";
            this.dataGridViewTextBoxColumn2.HeaderText = "MOVIE TITLE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "RENTED";
            this.dataGridViewCheckBoxColumn1.HeaderText = "RENTED";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // mOVIE_INFOBindingSource
            // 
            this.mOVIE_INFOBindingSource.DataMember = "MOVIE_INFO";
            this.mOVIE_INFOBindingSource.DataSource = this.mOVIESDataSet;
            // 
            // rENTALTableAdapter
            // 
            this.rENTALTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMER_INFOTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.MOVIE_INFOTableAdapter = null;
            this.tableAdapterManager.RENTALTableAdapter = this.rENTALTableAdapter;
            this.tableAdapterManager.UpdateOrder = MovieRental.MOVIESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mOVIE_INFOTableAdapter
            // 
            this.mOVIE_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // mOVIE_INFOBindingSource1
            // 
            this.mOVIE_INFOBindingSource1.DataMember = "MOVIE_INFO";
            this.mOVIE_INFOBindingSource1.DataSource = this.mOVIESDataSet1;
            // 
            // rentedOnly
            // 
            this.rentedOnly.AllowUserToAddRows = false;
            this.rentedOnly.AllowUserToDeleteRows = false;
            this.rentedOnly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedOnly.Location = new System.Drawing.Point(76, 237);
            this.rentedOnly.Name = "rentedOnly";
            this.rentedOnly.ReadOnly = true;
            this.rentedOnly.Size = new System.Drawing.Size(972, 256);
            this.rentedOnly.TabIndex = 37;
            this.rentedOnly.Visible = false;
            // 
            // showMovie2Btn
            // 
            this.showMovie2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.showMovie2Btn.Location = new System.Drawing.Point(463, 514);
            this.showMovie2Btn.Name = "showMovie2Btn";
            this.showMovie2Btn.Size = new System.Drawing.Size(191, 68);
            this.showMovie2Btn.TabIndex = 38;
            this.showMovie2Btn.Text = "SHOW  ALL MOVIES";
            this.showMovie2Btn.UseVisualStyleBackColor = true;
            this.showMovie2Btn.Visible = false;
            this.showMovie2Btn.Click += new System.EventHandler(this.showMovie2Btn_Click);
            // 
            // showMovie3Btn
            // 
            this.showMovie3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.showMovie3Btn.Location = new System.Drawing.Point(70, 514);
            this.showMovie3Btn.Name = "showMovie3Btn";
            this.showMovie3Btn.Size = new System.Drawing.Size(191, 68);
            this.showMovie3Btn.TabIndex = 39;
            this.showMovie3Btn.Text = "SHOW  ALL MOVIES";
            this.showMovie3Btn.UseVisualStyleBackColor = true;
            this.showMovie3Btn.Visible = false;
            this.showMovie3Btn.Click += new System.EventHandler(this.showMovie3Btn_Click);
            // 
            // hideMovieBtn
            // 
            this.hideMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.hideMovieBtn.Location = new System.Drawing.Point(660, 682);
            this.hideMovieBtn.Name = "hideMovieBtn";
            this.hideMovieBtn.Size = new System.Drawing.Size(191, 68);
            this.hideMovieBtn.TabIndex = 40;
            this.hideMovieBtn.Text = "HIDE  ALL MOVIES";
            this.hideMovieBtn.UseVisualStyleBackColor = true;
            this.hideMovieBtn.Visible = false;
            this.hideMovieBtn.Click += new System.EventHandler(this.hideMovieBtn_Click);
            // 
            // rentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 833);
            this.Controls.Add(this.hideMovieBtn);
            this.Controls.Add(this.showMovie3Btn);
            this.Controls.Add(this.showMovie2Btn);
            this.Controls.Add(this.allMovies);
            this.Controls.Add(this.rentedOnly);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rentalHistoryDataGrid);
            this.Controls.Add(this.rentalHistoryBtn);
            this.Controls.Add(this.rentedOnlyBtn);
            this.Controls.Add(this.rENTALBindingNavigator);
            this.Controls.Add(this.clearFormBtn);
            this.Controls.Add(this.dateReturnedTextBx);
            this.Controls.Add(this.newdateRentedTxtBx);
            this.Controls.Add(this.movieTitleTextBx);
            this.Controls.Add(this.movie_IDTextBox);
            this.Controls.Add(this.customer_IDTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.rentedChkBx);
            this.Controls.Add(this.customerMenuBtn);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.returnMovieBtn);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.addMovieBtn);
            this.Controls.Add(movie_IDLabel);
            this.Controls.Add(movieTitleLbl);
            this.Controls.Add(cUSTOMER_IDLabel);
            this.Controls.Add(dATE_RENTEDLabel);
            this.Controls.Add(dATE_RETURNEDLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rentForm";
            this.Text = "RentalInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rentForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingNavigator)).EndInit();
            this.rENTALBindingNavigator.ResumeLayout(false);
            this.rENTALBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIE_INFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIE_INFOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedOnly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.Button returnMovieBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.CheckBox rentedChkBx;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.TextBox movie_IDTextBox;
        private System.Windows.Forms.TextBox movieTitleTextBx;
        private System.Windows.Forms.TextBox newdateRentedTxtBx;
        private System.Windows.Forms.TextBox dateReturnedTextBx;
        private System.Windows.Forms.Button clearFormBtn;
        private MOVIESDataSet mOVIESDataSet;
        private System.Windows.Forms.BindingSource rENTALBindingSource;
        private MOVIESDataSetTableAdapters.RENTALTableAdapter rENTALTableAdapter;
        private MOVIESDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rENTALBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rENTALBindingNavigatorSaveItem;
        private System.Windows.Forms.Button rentedOnlyBtn;
        private System.Windows.Forms.Button rentalHistoryBtn;
        private System.Windows.Forms.BindingSource mOVIE_INFOBindingSource;
        private MOVIESDataSetTableAdapters.MOVIE_INFOTableAdapter mOVIE_INFOTableAdapter;
        private System.Windows.Forms.BindingSource mOVIESDataSet1BindingSource;
        private MOVIESDataSet mOVIESDataSet1;
        private System.Windows.Forms.BindingSource mOVIEINFOBindingSource;
        private System.Windows.Forms.DataGridView rentalHistoryDataGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource rENTALBindingSource1;
        private System.Windows.Forms.BindingSource mOVIE_INFOBindingSource1;
        private System.Windows.Forms.DataGridView allMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button customerMenuBtn;
        private System.Windows.Forms.DataGridView rentedOnly;
        private System.Windows.Forms.Button showMovie2Btn;
        private System.Windows.Forms.Button showMovie3Btn;
        private System.Windows.Forms.Button hideMovieBtn;
        private System.Windows.Forms.ToolStripMenuItem employeeMenuToolStripMenuItem;
    }
}