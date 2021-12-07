namespace Library_Management_System
{
    partial class Student_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_View));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowBookSearch = new System.Windows.Forms.Button();
            this.txtShowBookSearch = new System.Windows.Forms.TextBox();
            this.comboShowBookSearch = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnShowBookLogOut = new System.Windows.Forms.Button();
            this.btnShowBookRefresh = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvShowBooks = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPublished = new System.Windows.Forms.TextBox();
            this.txtCatagory = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPublished = new System.Windows.Forms.Label();
            this.labelCatagory = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelBookDetails = new System.Windows.Forms.Label();
            this.btnBorrowBookLogout = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReturnLogout = new System.Windows.Forms.Button();
            this.btnReturnRefresh = new System.Windows.Forms.Button();
            this.txtBookReturn = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrow_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtPayFine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoverImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBooks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowBookSearch);
            this.tabPage1.Controls.Add(this.txtShowBookSearch);
            this.tabPage1.Controls.Add(this.comboShowBookSearch);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.btnShowBookLogOut);
            this.tabPage1.Controls.Add(this.btnShowBookRefresh);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dgvShowBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShowBookSearch
            // 
            this.btnShowBookSearch.FlatAppearance.BorderSize = 0;
            this.btnShowBookSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnShowBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBookSearch.Location = new System.Drawing.Point(910, 139);
            this.btnShowBookSearch.Name = "btnShowBookSearch";
            this.btnShowBookSearch.Size = new System.Drawing.Size(99, 40);
            this.btnShowBookSearch.TabIndex = 16;
            this.btnShowBookSearch.Text = "Search";
            this.btnShowBookSearch.UseVisualStyleBackColor = true;
            this.btnShowBookSearch.Click += new System.EventHandler(this.btnShowBookSearch_Click);
            // 
            // txtShowBookSearch
            // 
            this.txtShowBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowBookSearch.Location = new System.Drawing.Point(875, 106);
            this.txtShowBookSearch.Name = "txtShowBookSearch";
            this.txtShowBookSearch.Size = new System.Drawing.Size(170, 27);
            this.txtShowBookSearch.TabIndex = 15;
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
            this.comboShowBookSearch.Location = new System.Drawing.Point(875, 71);
            this.comboShowBookSearch.Name = "comboShowBookSearch";
            this.comboShowBookSearch.Size = new System.Drawing.Size(170, 28);
            this.comboShowBookSearch.TabIndex = 14;
            this.comboShowBookSearch.Text = "Search Type";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(871, 47);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(128, 20);
            this.label34.TabIndex = 13;
            this.label34.Text = "Search Book :";
            // 
            // btnShowBookLogOut
            // 
            this.btnShowBookLogOut.FlatAppearance.BorderSize = 0;
            this.btnShowBookLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnShowBookLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBookLogOut.Location = new System.Drawing.Point(910, 446);
            this.btnShowBookLogOut.Name = "btnShowBookLogOut";
            this.btnShowBookLogOut.Size = new System.Drawing.Size(99, 40);
            this.btnShowBookLogOut.TabIndex = 12;
            this.btnShowBookLogOut.Text = "Log Out";
            this.btnShowBookLogOut.UseVisualStyleBackColor = true;
            this.btnShowBookLogOut.Click += new System.EventHandler(this.btnShowBookLogOut_Click);
            // 
            // btnShowBookRefresh
            // 
            this.btnShowBookRefresh.FlatAppearance.BorderSize = 0;
            this.btnShowBookRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnShowBookRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBookRefresh.Location = new System.Drawing.Point(910, 400);
            this.btnShowBookRefresh.Name = "btnShowBookRefresh";
            this.btnShowBookRefresh.Size = new System.Drawing.Size(99, 40);
            this.btnShowBookRefresh.TabIndex = 11;
            this.btnShowBookRefresh.Text = "Refresh";
            this.btnShowBookRefresh.UseVisualStyleBackColor = true;
            this.btnShowBookRefresh.Click += new System.EventHandler(this.btnShowBookRefresh_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(871, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Book : ";
            // 
            // dgvShowBooks
            // 
            this.dgvShowBooks.AllowUserToDeleteRows = false;
            this.dgvShowBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BookName,
            this.Author,
            this.PublicationYear,
            this.Catagory,
            this.CoverImage,
            this.Status});
            this.dgvShowBooks.Location = new System.Drawing.Point(8, 6);
            this.dgvShowBooks.Name = "dgvShowBooks";
            this.dgvShowBooks.ReadOnly = true;
            this.dgvShowBooks.RowTemplate.Height = 24;
            this.dgvShowBooks.Size = new System.Drawing.Size(854, 499);
            this.dgvShowBooks.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBorrow);
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.txtStatus);
            this.tabPage2.Controls.Add(this.txtPublished);
            this.tabPage2.Controls.Add(this.txtCatagory);
            this.tabPage2.Controls.Add(this.txtAuthorName);
            this.tabPage2.Controls.Add(this.txtBookName);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.labelStatus);
            this.tabPage2.Controls.Add(this.labelPublished);
            this.tabPage2.Controls.Add(this.labelCatagory);
            this.tabPage2.Controls.Add(this.labelAuthorName);
            this.tabPage2.Controls.Add(this.labelBookName);
            this.tabPage2.Controls.Add(this.labelBookDetails);
            this.tabPage2.Controls.Add(this.btnBorrowBookLogout);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrow Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(126, 378);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(85, 32);
            this.btnBorrow.TabIndex = 29;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(217, 378);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 32);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(129, 331);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(173, 22);
            this.txtStatus.TabIndex = 27;
            // 
            // txtPublished
            // 
            this.txtPublished.Location = new System.Drawing.Point(129, 295);
            this.txtPublished.Name = "txtPublished";
            this.txtPublished.ReadOnly = true;
            this.txtPublished.Size = new System.Drawing.Size(173, 22);
            this.txtPublished.TabIndex = 26;
            // 
            // txtCatagory
            // 
            this.txtCatagory.Location = new System.Drawing.Point(129, 259);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.ReadOnly = true;
            this.txtCatagory.Size = new System.Drawing.Size(173, 22);
            this.txtCatagory.TabIndex = 25;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(129, 222);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.ReadOnly = true;
            this.txtAuthorName.Size = new System.Drawing.Size(173, 22);
            this.txtAuthorName.TabIndex = 24;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(129, 183);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(173, 22);
            this.txtBookName.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(810, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(63, 331);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 17);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "Status : ";
            // 
            // labelPublished
            // 
            this.labelPublished.AutoSize = true;
            this.labelPublished.Location = new System.Drawing.Point(41, 295);
            this.labelPublished.Name = "labelPublished";
            this.labelPublished.Size = new System.Drawing.Size(82, 17);
            this.labelPublished.TabIndex = 20;
            this.labelPublished.Text = "Published : ";
            // 
            // labelCatagory
            // 
            this.labelCatagory.AutoSize = true;
            this.labelCatagory.Location = new System.Drawing.Point(46, 259);
            this.labelCatagory.Name = "labelCatagory";
            this.labelCatagory.Size = new System.Drawing.Size(77, 17);
            this.labelCatagory.TabIndex = 19;
            this.labelCatagory.Text = "Catagory : ";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(20, 222);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(103, 17);
            this.labelAuthorName.TabIndex = 18;
            this.labelAuthorName.Text = "Author Name : ";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(30, 185);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(93, 17);
            this.labelBookName.TabIndex = 17;
            this.labelBookName.Text = "Book Name : ";
            // 
            // labelBookDetails
            // 
            this.labelBookDetails.AutoSize = true;
            this.labelBookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookDetails.Location = new System.Drawing.Point(18, 135);
            this.labelBookDetails.Name = "labelBookDetails";
            this.labelBookDetails.Size = new System.Drawing.Size(167, 29);
            this.labelBookDetails.TabIndex = 16;
            this.labelBookDetails.Text = "Book Details : ";
            // 
            // btnBorrowBookLogout
            // 
            this.btnBorrowBookLogout.Location = new System.Drawing.Point(937, 465);
            this.btnBorrowBookLogout.Name = "btnBorrowBookLogout";
            this.btnBorrowBookLogout.Size = new System.Drawing.Size(85, 32);
            this.btnBorrowBookLogout.TabIndex = 15;
            this.btnBorrowBookLogout.Text = "Log Out";
            this.btnBorrowBookLogout.UseVisualStyleBackColor = true;
            this.btnBorrowBookLogout.Click += new System.EventHandler(this.btnBorrowBookLogout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 32);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 74);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 22);
            this.txtID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Book ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Get Your Book Here!";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnReturnLogout);
            this.tabPage3.Controls.Add(this.btnReturnRefresh);
            this.tabPage3.Controls.Add(this.txtBookReturn);
            this.tabPage3.Controls.Add(this.txtBookID);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtAccountStatus);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dgvOrderDetails);
            this.tabPage3.Controls.Add(this.btnPay);
            this.tabPage3.Controls.Add(this.txtPayFine);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtFine);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1054, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Return Book";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnReturnLogout
            // 
            this.btnReturnLogout.Location = new System.Drawing.Point(938, 476);
            this.btnReturnLogout.Name = "btnReturnLogout";
            this.btnReturnLogout.Size = new System.Drawing.Size(88, 28);
            this.btnReturnLogout.TabIndex = 15;
            this.btnReturnLogout.Text = "Log Out";
            this.btnReturnLogout.UseVisualStyleBackColor = true;
            this.btnReturnLogout.Click += new System.EventHandler(this.btnReturnLogout_Click);
            // 
            // btnReturnRefresh
            // 
            this.btnReturnRefresh.Location = new System.Drawing.Point(285, 351);
            this.btnReturnRefresh.Name = "btnReturnRefresh";
            this.btnReturnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnReturnRefresh.TabIndex = 14;
            this.btnReturnRefresh.Text = "Refresh";
            this.btnReturnRefresh.UseVisualStyleBackColor = true;
            this.btnReturnRefresh.Click += new System.EventHandler(this.btnReturnRefresh_Click);
            // 
            // txtBookReturn
            // 
            this.txtBookReturn.Location = new System.Drawing.Point(285, 287);
            this.txtBookReturn.Name = "txtBookReturn";
            this.txtBookReturn.Size = new System.Drawing.Size(88, 28);
            this.txtBookReturn.TabIndex = 13;
            this.txtBookReturn.Text = "Return";
            this.txtBookReturn.UseVisualStyleBackColor = true;
            this.txtBookReturn.Click += new System.EventHandler(this.txtBookReturn_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(143, 290);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Book ID : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Return Book : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Penalty : ";
            // 
            // txtAccountStatus
            // 
            this.txtAccountStatus.Location = new System.Drawing.Point(143, 30);
            this.txtAccountStatus.Name = "txtAccountStatus";
            this.txtAccountStatus.ReadOnly = true;
            this.txtAccountStatus.Size = new System.Drawing.Size(100, 22);
            this.txtAccountStatus.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Account Status :";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.BookId,
            this.Borrow_Date});
            this.dgvOrderDetails.Location = new System.Drawing.Point(683, 82);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.Size = new System.Drawing.Size(343, 150);
            this.dgvOrderDetails.TabIndex = 6;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "Id";
            this.OrderID.HeaderText = "Id";
            this.OrderID.Name = "OrderID";
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "Book Id";
            this.BookId.Name = "BookId";
            // 
            // Borrow_Date
            // 
            this.Borrow_Date.DataPropertyName = "Borrow_Date";
            this.Borrow_Date.HeaderText = "Borrow Date";
            this.Borrow_Date.Name = "Borrow_Date";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(285, 182);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(88, 28);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtPayFine
            // 
            this.txtPayFine.Location = new System.Drawing.Point(143, 186);
            this.txtPayFine.Name = "txtPayFine";
            this.txtPayFine.Size = new System.Drawing.Size(100, 22);
            this.txtPayFine.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pay Fine : ";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(143, 136);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(100, 22);
            this.txtFine.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Return Book";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
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
            // Student_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Student_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Manage System - Student View";
            this.Load += new System.EventHandler(this.Student_View_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBooks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowBookSearch;
        private System.Windows.Forms.TextBox txtShowBookSearch;
        private System.Windows.Forms.ComboBox comboShowBookSearch;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnShowBookLogOut;
        private System.Windows.Forms.Button btnShowBookRefresh;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvShowBooks;
        private System.Windows.Forms.Button btnBorrowBookLogout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPublished;
        private System.Windows.Forms.TextBox txtCatagory;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPublished;
        private System.Windows.Forms.Label labelCatagory;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelBookDetails;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox txtPayFine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.TextBox txtAccountStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrow_Date;
        private System.Windows.Forms.Button txtBookReturn;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReturnLogout;
        private System.Windows.Forms.Button btnReturnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewImageColumn CoverImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}