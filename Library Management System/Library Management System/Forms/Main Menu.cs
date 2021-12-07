using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.Forms;

namespace Library_Management_System
{
    public partial class Student_View : Form
    {
        private string userID, userType, uStatus;
        int userPenalty;

        public Student_View(string userID, string userType)
        {
            InitializeComponent();
            btnBorrow.Enabled = false;
            this.Text = "Library Management System - " + userType;
            this.userID = userID;
            this.userType = userType;
            WelcomeMessage();
        }

        #region Events
        private void Student_View_Load(object sender, EventArgs e)
        {
            LoadData();
            txtFine.Text = userPenalty.ToString();
            txtAccountStatus.Text = uStatus;
            OrderDetails();
        }        

        private void btnShowBookSearch_Click(object sender, EventArgs e)
        {
            string query;
            string countQuery;
            try
            {
                if (comboShowBookSearch.SelectedItem.ToString().Equals("Id"))
                {
                    query = "select * from Book where Id=" + int.Parse(txtShowBookSearch.Text) + "";
                    countQuery = "select count(*) from Book where Id=" + int.Parse(txtShowBookSearch.Text) + "";
                }

                else
                {
                    query = "select * from Book where " + comboShowBookSearch.SelectedItem.ToString() + "='" + txtShowBookSearch.Text + "'";
                    countQuery = "select count(*) from Book where " + comboShowBookSearch.SelectedItem.ToString() + "='" + txtShowBookSearch.Text + "'";
                }
            }
            catch (Exception)
            {
                query = "select * from Book";
                countQuery = "select count(*) from Book";
                MessageBox.Show("Not Found");
            }

            DataTable dt = DataAccess.LoadData(query);
            DataTable countBook = DataAccess.LoadData(countQuery);
            dgvShowBooks.AutoGenerateColumns = false;
            dgvShowBooks.RowTemplate.Height = 150;
            ((DataGridViewImageColumn)dgvShowBooks.Columns[5]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvShowBooks.DataSource = dt;
            lblTotal.Text = "Total Book : " + countBook.Rows[0][0].ToString();
        }

        private void btnShowBookRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnShowBookLogOut_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        private void btnBorrowBookLogout_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Enter Book ID");
            }
            else
            {
                try
                {
                    string query = "select * from Book where Id=" + int.Parse(txtID.Text) + "";
                    DataTable dt = DataAccess.LoadData(query);
                    txtBookName.Text = dt.Rows[0][1].ToString();
                    txtPublished.Text = dt.Rows[0][3].ToString();
                    txtCatagory.Text = dt.Rows[0][7].ToString();
                    txtAuthorName.Text = dt.Rows[0][2].ToString();
                    txtStatus.Text = dt.Rows[0][6].ToString();

                    try
                    {
                        byte[] img = (byte[])dt.Rows[0][5];
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch (Exception)
                    {
                        pictureBox1.Image = null;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Not found");
                }
            }
            btnBorrow.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtBookName.Text = "";
            txtPublished.Text = "";
            txtCatagory.Text = "";
            txtAuthorName.Text = "";
            txtStatus.Text = "";
            pictureBox1.Image = null;
            btnBorrow.Enabled = false;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (CheckIDStatus())
            {
                if (checkBookStatus(txtID.Text))
                {
                    string borrowDate = DateTime.Now.ToString();
                    string query = "insert into Borrow(BookId,UserId,Borrow_Date,Return_Date) values(" + int.Parse(txtID.Text) + ",'" + userID + "', '" + borrowDate + "', null)";
                    DataAccess.ExecuteQuery(query);
                    query = "update Book set Status='Not Available' where Id=" + int.Parse(txtID.Text) + "";
                    DataAccess.ExecuteQuery(query);
                    MessageBox.Show("Book Borrowed");
                }                
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }               

        private void txtBookReturn_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text.Equals(""))
            {
                MessageBox.Show("Please enter book id");
            }
            else
            {
                DataAccess.ExecuteQuery("delete from Borrow where BookId=" + int.Parse(txtBookID.Text) + "");
                DataAccess.ExecuteQuery("update Book set Status='Available' where Id=" + int.Parse(txtBookID.Text) + "");
                MessageBox.Show("Thanks for return");
            }
        }

        private void btnReturnRefresh_Click(object sender, EventArgs e)
        {
            txtPayFine.Text = "";
            txtBookID.Text = "";
            OrderDetails();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (uStatus.Equals("Invalid"))
            {
                if (txtPayFine.Text.Equals(userPenalty.ToString()))
                {
                    DataAccess.ExecuteQuery("update " + userType + " set Account_Status='Valid' where Id='" + userID + "'");
                    DataAccess.ExecuteQuery("delete from Penalty where UserID='" + userID + "'");
                    MessageBox.Show("Payment successful");
                    txtAccountStatus.Text = "Valid";
                    txtFine.Text = "";
                }
                else if (txtPayFine.Text.Equals(""))
                {
                    MessageBox.Show("Please Enter Money Amount");
                }
                else
                {
                    MessageBox.Show("Sorry\nYou can't pay\nMore or less than : " + userPenalty);
                }
            }
            else
            {
                MessageBox.Show("Your account is valid");
            }

        }

        private void btnReturnLogout_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        #endregion

        #region Methods
        private int CheckAndSetPenalty()
        {
            string query = "select Borrow_Date from Borrow where UserId='" + userID + "'";
            DataTable dt = DataAccess.LoadData(query);
            try
            {
                string date = dt.Rows[0][0].ToString();
                DateTime borrowDate = DateTime.Parse(date);
                DateTime today = DateTime.Now;
                TimeSpan ts = today - borrowDate;
                int totalDays = (int)ts.TotalDays;
                int sFineAmount = 10;
                int fFineAmount = 50;
                int sFineDay = totalDays - 7;
                int fFineDay = totalDays - 90;

                if (userType.Equals("Student"))
                {
                    if (totalDays > 7)
                    {
                        DataAccess.ExecuteQuery("update " + userType + " set Account_Status='Invalid' where Id='" + userID + "'");
                        int r = DataAccess.ExecuteQuery("update Penalty set Fine='" + (sFineDay * sFineAmount) + "' where UserID='" + userID + "'");
                        if (r >= 1)
                        {
                            return sFineDay * sFineAmount;
                        }
                        else
                        {
                            DataAccess.ExecuteQuery("insert into Penalty(UserID, Fine, Status) values('" + userID + "','" + (sFineDay * sFineAmount) + "','Invalid') ");
                            return sFineDay * sFineAmount;
                        }
                    }
                    return 0;
                }
                else if (userType.Equals("Faculty"))
                {
                    if (totalDays > 90)
                    {
                        DataAccess.ExecuteQuery("update " + userType + " set Account_Status='Invalid' where Id='" + userID + "'");
                        int r = DataAccess.ExecuteQuery("update Penalty set Fine='" + (fFineDay * fFineAmount) + "' where UserID='" + userID + "'");
                        if (r >= 1)
                        {
                            return fFineDay * fFineAmount;
                        }
                        else
                        {
                            DataAccess.ExecuteQuery("insert into Penalty(UserID, Fine, Status) values('" + userID + "','" + (fFineDay * fFineAmount) + "','Invalid') ");
                            return fFineDay * fFineAmount;
                        }
                    }
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        private void OrderDetails()
        {
            DataTable dt = DataAccess.LoadData("select * from Borrow where UserId='" + userID + "'");
            dgvOrderDetails.AutoGenerateColumns = false;
            dgvOrderDetails.DataSource = dt;
        }

        private void LoadData()
        {
            DataTable dt = DataAccess.LoadData("select * from Book");
            dgvShowBooks.AutoGenerateColumns = false;
            dgvShowBooks.RowTemplate.Height = 150;
            ((DataGridViewImageColumn)dgvShowBooks.Columns[5]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvShowBooks.DataSource = dt;

            DataTable dt2 = DataAccess.LoadData("select count(*) from Book");
            lblTotal.Text = "Total Book : " + dt2.Rows[0][0].ToString();
        }

        private bool checkBookStatus(string bookId)
        {
            string query = "select Status from Book where Id='" + bookId + "'";
            DataTable dt = DataAccess.LoadData(query);
            string status = dt.Rows[0][0].ToString();
            if (status.Equals("Available"))
            {
                return true;
            }
            else if (status.Equals("Reserve"))
            {
                MessageBox.Show("Sorry, you can't take reserved book");
                return false;
            }
            else
            {
                MessageBox.Show("The book is not available");
                return false;
            }
        }

        private void WelcomeMessage()
        {
            userPenalty = CheckAndSetPenalty();
            if (CheckIDStatus())
            {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Your current status is Invalid\nPay fine : " + userPenalty + "\nReturn Book");
            }
        }

        private bool CheckIDStatus()
        {
            string query = "select Account_Status from " + userType + " where Id='" + userID + "'";
            DataTable dt = DataAccess.LoadData(query);
            uStatus = dt.Rows[0][0].ToString();

            if (uStatus.Equals("Valid"))
            {
                return true;
            }
            return false;
        }
        #endregion

    }
}
