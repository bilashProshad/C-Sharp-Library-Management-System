namespace Library_Management_System
{
    partial class Librarian_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarian_View));
            this.tab_LibraryView = new System.Windows.Forms.TabControl();
            this.tabShowBooks = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboStatusUpdate = new System.Windows.Forms.ComboBox();
            this.txtCatagoryUpdate = new System.Windows.Forms.TextBox();
            this.txtPublishedUpdate = new System.Windows.Forms.TextBox();
            this.txtAuthorUpdate = new System.Windows.Forms.TextBox();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.btnShowBookSearch = new System.Windows.Forms.Button();
            this.txtShowBookSearch = new System.Windows.Forms.TextBox();
            this.comboShowBookSearch = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnShowBookLogOut = new System.Windows.Forms.Button();
            this.btnShowBookRefresh = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvShowBooks = new System.Windows.Forms.DataGridView();
            this.IDBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoverImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAddBook = new System.Windows.Forms.TabPage();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtCatagory = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnAddBookLogout = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnRefreshOrder = new System.Windows.Forms.Button();
            this.txtSearchOrder = new System.Windows.Forms.TextBox();
            this.comboSearchOrder = new System.Windows.Forms.ComboBox();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.OderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrow_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogOutOrder = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.tab_LibraryView.SuspendLayout();
            this.tabShowBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBooks)).BeginInit();
            this.tabAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_LibraryView
            // 
            this.tab_LibraryView.Controls.Add(this.tabShowBooks);
            this.tab_LibraryView.Controls.Add(this.tabAddBook);
            this.tab_LibraryView.Controls.Add(this.tabPage7);
            this.tab_LibraryView.ItemSize = new System.Drawing.Size(51, 25);
            this.tab_LibraryView.Location = new System.Drawing.Point(0, 0);
            this.tab_LibraryView.Name = "tab_LibraryView";
            this.tab_LibraryView.SelectedIndex = 0;
            this.tab_LibraryView.Size = new System.Drawing.Size(1062, 553);
            this.tab_LibraryView.TabIndex = 0;
            // 
            // tabShowBooks
            // 
            this.tabShowBooks.Controls.Add(this.btnUpdate);
            this.tabShowBooks.Controls.Add(this.comboStatusUpdate);
            this.tabShowBooks.Controls.Add(this.txtCatagoryUpdate);
            this.tabShowBooks.Controls.Add(this.txtPublishedUpdate);
            this.tabShowBooks.Controls.Add(this.txtAuthorUpdate);
            this.tabShowBooks.Controls.Add(this.txtNameUpdate);
            this.tabShowBooks.Controls.Add(this.btnShowBookSearch);
            this.tabShowBooks.Controls.Add(this.txtShowBookSearch);
            this.tabShowBooks.Controls.Add(this.comboShowBookSearch);
            this.tabShowBooks.Controls.Add(this.label34);
            this.tabShowBooks.Controls.Add(this.btnShowBookLogOut);
            this.tabShowBooks.Controls.Add(this.btnShowBookRefresh);
            this.tabShowBooks.Controls.Add(this.lblTotal);
            this.tabShowBooks.Controls.Add(this.dgvShowBooks);
            this.tabShowBooks.Location = new System.Drawing.Point(4, 29);
            this.tabShowBooks.Margin = new System.Windows.Forms.Padding(4);
            this.tabShowBooks.Name = "tabShowBooks";
            this.tabShowBooks.Size = new System.Drawing.Size(1054, 520);
            this.tabShowBooks.TabIndex = 4;
            this.tabShowBooks.Text = "Books";
            this.tabShowBooks.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(907, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 40);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboStatusUpdate
            // 
            this.comboStatusUpdate.FormattingEnabled = true;
            this.comboStatusUpdate.Items.AddRange(new object[] {
            "Available",
            "Reserve"});
            this.comboStatusUpdate.Location = new System.Drawing.Point(869, 328);
            this.comboStatusUpdate.Name = "comboStatusUpdate";
            this.comboStatusUpdate.Size = new System.Drawing.Size(179, 24);
            this.comboStatusUpdate.TabIndex = 13;
            this.comboStatusUpdate.Text = "Select Status";
            // 
            // txtCatagoryUpdate
            // 
            this.txtCatagoryUpdate.Location = new System.Drawing.Point(869, 300);
            this.txtCatagoryUpdate.Name = "txtCatagoryUpdate";
            this.txtCatagoryUpdate.Size = new System.Drawing.Size(179, 22);
            this.txtCatagoryUpdate.TabIndex = 12;
            // 
            // txtPublishedUpdate
            // 
            this.txtPublishedUpdate.Location = new System.Drawing.Point(869, 272);
            this.txtPublishedUpdate.Name = "txtPublishedUpdate";
            this.txtPublishedUpdate.Size = new System.Drawing.Size(179, 22);
            this.txtPublishedUpdate.TabIndex = 11;
            // 
            // txtAuthorUpdate
            // 
            this.txtAuthorUpdate.Location = new System.Drawing.Point(869, 244);
            this.txtAuthorUpdate.Name = "txtAuthorUpdate";
            this.txtAuthorUpdate.Size = new System.Drawing.Size(179, 22);
            this.txtAuthorUpdate.TabIndex = 10;
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(869, 216);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(179, 22);
            this.txtNameUpdate.TabIndex = 9;
            // 
            // btnShowBookSearch
            // 
            this.btnShowBookSearch.FlatAppearance.BorderSize = 0;
            this.btnShowBookSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnShowBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBookSearch.Location = new System.Drawing.Point(907, 149);
            this.btnShowBookSearch.Name = "btnShowBookSearch";
            this.btnShowBookSearch.Size = new System.Drawing.Size(99, 40);
            this.btnShowBookSearch.TabIndex = 8;
            this.btnShowBookSearch.Text = "Search";
            this.btnShowBookSearch.UseVisualStyleBackColor = true;
            this.btnShowBookSearch.Click += new System.EventHandler(this.btnShowBookSearch_Click);
            // 
            // txtShowBookSearch
            // 
            this.txtShowBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowBookSearch.Location = new System.Drawing.Point(872, 116);
            this.txtShowBookSearch.Name = "txtShowBookSearch";
            this.txtShowBookSearch.Size = new System.Drawing.Size(170, 27);
            this.txtShowBookSearch.TabIndex = 7;
            // 
            // comboShowBookSearch
            // 
            this.comboShowBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboShowBookSearch.FormattingEnabled = true;
            this.comboShowBookSearch.Items.AddRange(new object[] {
            "Id",
            "BookName",
            "Author",
            "Catagory",
            "PublicationYear",
            "Status"});
            this.comboShowBookSearch.Location = new System.Drawing.Point(872, 81);
            this.comboShowBookSearch.Name = "comboShowBookSearch";
            this.comboShowBookSearch.Size = new System.Drawing.Size(170, 28);
            this.comboShowBookSearch.TabIndex = 6;
            this.comboShowBookSearch.Text = "Search Type";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(868, 57);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(128, 20);
            this.label34.TabIndex = 5;
            this.label34.Text = "Search Book :";
            // 
            // btnShowBookLogOut
            // 
            this.btnShowBookLogOut.FlatAppearance.BorderSize = 0;
            this.btnShowBookLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnShowBookLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBookLogOut.Location = new System.Drawing.Point(907, 469);
            this.btnShowBookLogOut.Name = "btnShowBookLogOut";
            this.btnShowBookLogOut.Size = new System.Drawing.Size(99, 40);
            this.btnShowBookLogOut.TabIndex = 3;
            this.btnShowBookLogOut.Text = "Log Out";
            this.btnShowBookLogOut.UseVisualStyleBackColor = true;
            this.btnShowBookLogOut.Click += new System.EventHandler(this.btnShowBookLogOut_Click);
            // 
            // btnShowBookRefresh
            // 
            this.btnShowBookRefresh.FlatAppearance.BorderSize = 0;
            this.btnShowBookRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnShowBookRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBookRefresh.Location = new System.Drawing.Point(907, 423);
            this.btnShowBookRefresh.Name = "btnShowBookRefresh";
            this.btnShowBookRefresh.Size = new System.Drawing.Size(99, 40);
            this.btnShowBookRefresh.TabIndex = 2;
            this.btnShowBookRefresh.Text = "Refresh";
            this.btnShowBookRefresh.UseVisualStyleBackColor = true;
            this.btnShowBookRefresh.Click += new System.EventHandler(this.btnShowBookRefresh_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(868, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total Book : ";
            // 
            // dgvShowBooks
            // 
            this.dgvShowBooks.AllowUserToDeleteRows = false;
            this.dgvShowBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBook,
            this.BookName,
            this.Author,
            this.PublicationYear,
            this.Catagory,
            this.CoverImage,
            this.Status});
            this.dgvShowBooks.Location = new System.Drawing.Point(8, 12);
            this.dgvShowBooks.Name = "dgvShowBooks";
            this.dgvShowBooks.ReadOnly = true;
            this.dgvShowBooks.RowTemplate.Height = 24;
            this.dgvShowBooks.Size = new System.Drawing.Size(854, 499);
            this.dgvShowBooks.TabIndex = 0;
            this.dgvShowBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowBooks_CellClick);
            // 
            // IDBook
            // 
            this.IDBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDBook.DataPropertyName = "Id";
            this.IDBook.HeaderText = "ID";
            this.IDBook.Name = "IDBook";
            this.IDBook.ReadOnly = true;
            this.IDBook.Width = 50;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 165;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 165;
            // 
            // PublicationYear
            // 
            this.PublicationYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PublicationYear.DataPropertyName = "PublicationYear";
            this.PublicationYear.HeaderText = "Published";
            this.PublicationYear.Name = "PublicationYear";
            this.PublicationYear.ReadOnly = true;
            this.PublicationYear.Width = 99;
            // 
            // Catagory
            // 
            this.Catagory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Catagory.DataPropertyName = "Catagory";
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            this.Catagory.Width = 94;
            // 
            // CoverImage
            // 
            this.CoverImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CoverImage.DataPropertyName = "CoverImage";
            this.CoverImage.HeaderText = "Cover Image";
            this.CoverImage.Name = "CoverImage";
            this.CoverImage.ReadOnly = true;
            this.CoverImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CoverImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CoverImage.Width = 150;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 77;
            // 
            // tabAddBook
            // 
            this.tabAddBook.Controls.Add(this.comboStatus);
            this.tabAddBook.Controls.Add(this.label32);
            this.tabAddBook.Controls.Add(this.txtCatagory);
            this.tabAddBook.Controls.Add(this.label31);
            this.tabAddBook.Controls.Add(this.btnBrowse);
            this.tabAddBook.Controls.Add(this.txtAuthorName);
            this.tabAddBook.Controls.Add(this.btnAddBookLogout);
            this.tabAddBook.Controls.Add(this.btnRefresh);
            this.tabAddBook.Controls.Add(this.btnAddBooks);
            this.tabAddBook.Controls.Add(this.label38);
            this.tabAddBook.Controls.Add(this.pictureBox4);
            this.tabAddBook.Controls.Add(this.txtPublicationYear);
            this.tabAddBook.Controls.Add(this.txtPrice);
            this.tabAddBook.Controls.Add(this.txtBookName);
            this.tabAddBook.Controls.Add(this.label33);
            this.tabAddBook.Controls.Add(this.label35);
            this.tabAddBook.Controls.Add(this.label36);
            this.tabAddBook.Controls.Add(this.label37);
            this.tabAddBook.Location = new System.Drawing.Point(4, 29);
            this.tabAddBook.Name = "tabAddBook";
            this.tabAddBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddBook.Size = new System.Drawing.Size(1054, 520);
            this.tabAddBook.TabIndex = 1;
            this.tabAddBook.Text = "Add Book";
            this.tabAddBook.UseVisualStyleBackColor = true;
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Available",
            "Reserve"});
            this.comboStatus.Location = new System.Drawing.Point(256, 224);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(179, 24);
            this.comboStatus.TabIndex = 47;
            this.comboStatus.Text = "Select Book Status";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(180, 222);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(70, 24);
            this.label32.TabIndex = 46;
            this.label32.Text = "Status :";
            // 
            // txtCatagory
            // 
            this.txtCatagory.Location = new System.Drawing.Point(256, 162);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.Size = new System.Drawing.Size(179, 22);
            this.txtCatagory.TabIndex = 45;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(155, 159);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(94, 24);
            this.label31.TabIndex = 44;
            this.label31.Text = "Catagory :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnBrowse.Location = new System.Drawing.Point(833, 311);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 35);
            this.btnBrowse.TabIndex = 43;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(256, 106);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(179, 22);
            this.txtAuthorName.TabIndex = 42;
            // 
            // btnAddBookLogout
            // 
            this.btnAddBookLogout.FlatAppearance.BorderSize = 0;
            this.btnAddBookLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnAddBookLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookLogout.Location = new System.Drawing.Point(939, 483);
            this.btnAddBookLogout.Name = "btnAddBookLogout";
            this.btnAddBookLogout.Size = new System.Drawing.Size(109, 33);
            this.btnAddBookLogout.TabIndex = 41;
            this.btnAddBookLogout.Text = "Log Out";
            this.btnAddBookLogout.UseVisualStyleBackColor = true;
            this.btnAddBookLogout.Click += new System.EventHandler(this.btnAddBookLogout_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(326, 256);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 32);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.FlatAppearance.BorderSize = 0;
            this.btnAddBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnAddBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooks.Location = new System.Drawing.Point(198, 256);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(122, 34);
            this.btnAddBooks.TabIndex = 39;
            this.btnAddBooks.Text = "Add Books";
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(427, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(201, 29);
            this.label38.TabIndex = 38;
            this.label38.Text = "Store New Books";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(760, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(215, 223);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Location = new System.Drawing.Point(256, 134);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(179, 22);
            this.txtPublicationYear.TabIndex = 32;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(256, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(179, 22);
            this.txtPrice.TabIndex = 30;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(256, 71);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(179, 22);
            this.txtBookName.TabIndex = 28;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(94, 132);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(156, 24);
            this.label33.TabIndex = 26;
            this.label33.Text = "Publication Year :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(187, 190);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 24);
            this.label35.TabIndex = 24;
            this.label35.Text = "Price :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(118, 108);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(132, 24);
            this.label36.TabIndex = 23;
            this.label36.Text = "Author Name :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(131, 71);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(119, 24);
            this.label37.TabIndex = 22;
            this.label37.Text = "Book Name :";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnRefreshOrder);
            this.tabPage7.Controls.Add(this.txtSearchOrder);
            this.tabPage7.Controls.Add(this.comboSearchOrder);
            this.tabPage7.Controls.Add(this.btnSearchOrder);
            this.tabPage7.Controls.Add(this.dgvOrderHistory);
            this.tabPage7.Controls.Add(this.btnLogOutOrder);
            this.tabPage7.Controls.Add(this.label23);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1054, 520);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Order History";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnRefreshOrder
            // 
            this.btnRefreshOrder.Location = new System.Drawing.Point(148, 187);
            this.btnRefreshOrder.Name = "btnRefreshOrder";
            this.btnRefreshOrder.Size = new System.Drawing.Size(94, 36);
            this.btnRefreshOrder.TabIndex = 53;
            this.btnRefreshOrder.Text = "Refresh";
            this.btnRefreshOrder.UseVisualStyleBackColor = true;
            this.btnRefreshOrder.Click += new System.EventHandler(this.btnRefreshOrder_Click);
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.Location = new System.Drawing.Point(40, 136);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.Size = new System.Drawing.Size(202, 22);
            this.txtSearchOrder.TabIndex = 52;
            // 
            // comboSearchOrder
            // 
            this.comboSearchOrder.FormattingEnabled = true;
            this.comboSearchOrder.Items.AddRange(new object[] {
            "Order ID",
            "Book ID",
            "User ID"});
            this.comboSearchOrder.Location = new System.Drawing.Point(40, 92);
            this.comboSearchOrder.Name = "comboSearchOrder";
            this.comboSearchOrder.Size = new System.Drawing.Size(202, 24);
            this.comboSearchOrder.TabIndex = 51;
            this.comboSearchOrder.Text = "Search Type";
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(40, 187);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(94, 36);
            this.btnSearchOrder.TabIndex = 50;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.AllowUserToDeleteRows = false;
            this.dgvOrderHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OderID,
            this.BookId,
            this.UserId,
            this.Borrow_Date});
            this.dgvOrderHistory.Location = new System.Drawing.Point(547, 83);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.ReadOnly = true;
            this.dgvOrderHistory.RowTemplate.Height = 24;
            this.dgvOrderHistory.Size = new System.Drawing.Size(427, 225);
            this.dgvOrderHistory.TabIndex = 49;
            // 
            // OderID
            // 
            this.OderID.DataPropertyName = "Id";
            this.OderID.HeaderText = "Order ID";
            this.OderID.Name = "OderID";
            this.OderID.ReadOnly = true;
            this.OderID.Width = 91;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "Book ID";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Width = 86;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User ID";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 84;
            // 
            // Borrow_Date
            // 
            this.Borrow_Date.DataPropertyName = "Borrow_Date";
            this.Borrow_Date.HeaderText = "Borrow Date";
            this.Borrow_Date.Name = "Borrow_Date";
            this.Borrow_Date.ReadOnly = true;
            this.Borrow_Date.Width = 115;
            // 
            // btnLogOutOrder
            // 
            this.btnLogOutOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutOrder.Location = new System.Drawing.Point(948, 483);
            this.btnLogOutOrder.Name = "btnLogOutOrder";
            this.btnLogOutOrder.Size = new System.Drawing.Size(98, 33);
            this.btnLogOutOrder.TabIndex = 48;
            this.btnLogOutOrder.Text = "Log Out";
            this.btnLogOutOrder.UseVisualStyleBackColor = true;
            this.btnLogOutOrder.Click += new System.EventHandler(this.btnLogOutOrder_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(396, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(215, 29);
            this.label23.TabIndex = 47;
            this.label23.Text = "View Order Details";
            // 
            // Librarian_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.tab_LibraryView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Librarian_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Manage System - Librarian View";
            this.Load += new System.EventHandler(this.Librarian_View_Load);
            this.tab_LibraryView.ResumeLayout(false);
            this.tabShowBooks.ResumeLayout(false);
            this.tabShowBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBooks)).EndInit();
            this.tabAddBook.ResumeLayout(false);
            this.tabAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tab_LibraryView;
        private System.Windows.Forms.TabPage tabAddBook;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddBookLogout;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TabPage tabShowBooks;
        private System.Windows.Forms.DataGridView dgvShowBooks;
        private System.Windows.Forms.TextBox txtCatagory;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnShowBookLogOut;
        private System.Windows.Forms.Button btnShowBookRefresh;
        private System.Windows.Forms.ComboBox comboShowBookSearch;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnShowBookSearch;
        private System.Windows.Forms.TextBox txtShowBookSearch;
        private System.Windows.Forms.TextBox txtCatagoryUpdate;
        private System.Windows.Forms.TextBox txtPublishedUpdate;
        private System.Windows.Forms.TextBox txtAuthorUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.ComboBox comboStatusUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvOrderHistory;
        private System.Windows.Forms.Button btnLogOutOrder;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn OderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrow_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewImageColumn CoverImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnRefreshOrder;
        private System.Windows.Forms.TextBox txtSearchOrder;
        private System.Windows.Forms.ComboBox comboSearchOrder;
        private System.Windows.Forms.Button btnSearchOrder;
    }
}