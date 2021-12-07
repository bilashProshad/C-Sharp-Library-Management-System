using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Library_Management_System.Forms;

namespace Library_Management_System
{
    public partial class Librarian_View : Form
    {
        public Librarian_View(string userID)
        {
            InitializeComponent();
            HideAllUpdateTextBox();
        }

        string imageLocation = "";
        public DataGridViewImageCellLayout ImageLayout { get; private set; }
        private string id;

        #region Events
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|aaa|*.aaa|png files(*.png)|*.png|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                pictureBox4.ImageLocation = imageLocation;
            }
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream;
            BinaryReader brs;
            string query;
            try
            {
                stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                query = "insert into Book(BookName,Author,PublicationYear,Price,CoverImage,Status,Catagory) values('" + txtBookName.Text + "','" + txtAuthorName.Text + "','" + txtPublicationYear.Text + "'," + int.Parse(txtPrice.Text) + ",@images,'" + comboStatus.SelectedItem.ToString() + "','" + txtCatagory.Text + "')";
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill all boxes\nAnd also set picture");
                query = "";
            }
            
            int r = DataAccess.InsertDataImage(query, images);

            if (r >= 1)
            {
                MessageBox.Show("Book Added");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void Librarian_View_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadOrderHistory();
        }       

        private void btnShowBookRefresh_Click(object sender, EventArgs e)
        {
            HideAllUpdateTextBox();
            LoadData();
        }

        private void btnShowBookLogOut_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        private void btnAddBookLogout_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
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
                    countQuery = "select count(*) from Book where Id="+ int.Parse(txtShowBookSearch.Text) + "";
                }

                else
                {
                    query = "select * from Book where " + comboShowBookSearch.SelectedItem.ToString() + "='" + txtShowBookSearch.Text + "'";
                    countQuery = "select count(*) from Book where "+ comboShowBookSearch.SelectedItem.ToString() + "='"+ txtShowBookSearch.Text + "'";
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

        private void dgvShowBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowAllUpdateTextBox();
            int indexRow = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvShowBooks.Rows[indexRow];

                id = row.Cells[0].Value.ToString();
                txtNameUpdate.Text = row.Cells[1].Value.ToString();
                txtAuthorUpdate.Text = row.Cells[2].Value.ToString();
                txtPublishedUpdate.Text = row.Cells[3].Value.ToString();
                txtCatagoryUpdate.Text = row.Cells[4].Value.ToString();
                comboStatusUpdate.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HideAllUpdateTextBox();
            string query = "update Book set BookName='"+ txtNameUpdate.Text + "', Author='"+ txtAuthorUpdate.Text + "', PublicationYear='"+ txtPublishedUpdate.Text + "', Status='"+ comboStatusUpdate.SelectedItem.ToString() + "', Catagory='"+ txtCatagoryUpdate.Text + "' where Id="+id+"";
            DataAccess.ExecuteQuery(query);
            MessageBox.Show("Updated");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAuthorName.Text = "";
            txtBookName.Text = "";
            txtPublicationYear.Text = "";
            txtCatagory.Text = "";
            txtPrice.Text = "";
            comboStatus.Text = "Select Book Status";
            pictureBox4.Image = null;
        }

        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            txtSearchOrder.Text = "";
            comboSearchOrder.Text = "Select Type";
            LoadOrderHistory();
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            string query;
            try
            {
                if (comboSearchOrder.SelectedItem.ToString().Equals("User ID"))
                {
                    query = "select * from Borrow where UserId='" + txtSearchOrder.Text + "'";
                }
                else if (comboSearchOrder.SelectedItem.ToString().Equals("Book ID"))
                {
                    query = "select * from Borrow where BookId=" + txtSearchOrder.Text + "";
                }
                else if (comboSearchOrder.SelectedItem.ToString().Equals("Order ID"))
                {
                    query = "select * from Borrow where Id=" + txtSearchOrder.Text + "";
                }
                else
                {
                    query = "select * from Borrow";
                }

                DataTable dt = DataAccess.LoadData(query);
                dgvOrderHistory.AutoGenerateColumns = false;
                dgvOrderHistory.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select search type\nFill the box");
            }
        }

        private void btnLogOutOrder_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }
        #endregion

        #region Methods
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

        private void LoadOrderHistory()
        {
            DataTable dt = DataAccess.LoadData("select * from Borrow");
            dgvOrderHistory.AutoGenerateColumns = false;
            dgvOrderHistory.DataSource = dt;
        }

        private void HideAllUpdateTextBox()
        {
            txtNameUpdate.Visible = false;
            txtAuthorUpdate.Visible = false;
            txtPublishedUpdate.Visible = false;
            txtCatagoryUpdate.Visible = false;
            comboStatusUpdate.Visible = false;
            btnUpdate.Visible = false;
        }

        private void ShowAllUpdateTextBox()
        {
            txtNameUpdate.Visible = true;
            txtAuthorUpdate.Visible = true;
            txtPublishedUpdate.Visible = true;
            txtCatagoryUpdate.Visible = true;
            comboStatusUpdate.Visible = true;
            btnUpdate.Visible = true;
        }

        #endregion

       
    }
}
