using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Forms
{
    public partial class LoginFrom : Form
    {      
        private string uID = "";
        private string uPassword = "";
        private string uType = "";

        public LoginFrom()
        {
            InitializeComponent();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            txtPassword.ForeColor = Color.Black;
        }

        private void txtUserID_Enter(object sender, EventArgs e)
        {
            if (txtUserID.Text == "User ID")
                txtUserID.Clear();
            txtUserID.ForeColor = Color.Black;
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                txtUserID.Text = "User ID";
                txtUserID.ForeColor = Color.Silver;
            }                
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm();
            sf.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            string query = "select * from AllUser where Id='"+ txtUserID.Text + "'";
            DataTable dt = DataAccess.LoadData(query);

            try
            {
                uID = dt.Rows[0][0].ToString();
                uPassword = dt.Rows[0][1].ToString();
                uType = dt.Rows[0][2].ToString();

                if (uID.Equals(txtUserID.Text))
                {
                    if (uPassword.Equals(txtPassword.Text))
                    {
                        LoadNextForm(uType);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User Id");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid ID or Password");
            }

        }

        private void LoadNextForm(string uType)
        {
            if (uType.Equals("Librarian"))
            {
                Librarian_View lv = new Librarian_View(txtUserID.Text.ToString());
                lv.Show();
                this.Hide();
            }
            
            else
            {
                Student_View sv = new Student_View(txtUserID.Text.ToString(), uType);
                sv.Show();
                this.Hide();
            }
        }      
        
    }
}
