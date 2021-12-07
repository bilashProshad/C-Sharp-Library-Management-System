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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            
        }

        private string dob;
        private string userType;
        

        #region Textbox_Region
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID")
                txtID.Clear();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "ID";
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Full Name")
                txtName.Clear();
            txtName.ForeColor = Color.Black;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Full Name";
                txtName.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
                txtEmail.Clear();
            txtEmail.ForeColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }                
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            txtPassword.ForeColor = Color.Black;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtDepartment_Enter(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "Department")
                txtDepartment.Clear();
            txtDepartment.ForeColor = Color.Black;
        }

        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "")
            {
                txtDepartment.Text = "Department";
                txtDepartment.ForeColor = Color.Silver;
            }
        }

        private void txtMobNo_Enter(object sender, EventArgs e)
        {
            if (txtMobNo.Text == "Mobile Number")
                txtMobNo.Clear();
            txtMobNo.ForeColor = Color.Black;
        }

        private void txtMobNo_Leave(object sender, EventArgs e)
        {
            if (txtMobNo.Text == "")
            {
                txtMobNo.Text = "Mobile Number";
                txtMobNo.ForeColor = Color.Silver;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
                txtAddress.Clear();
            txtAddress.ForeColor = Color.Black;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Address";
                txtAddress.ForeColor = Color.Silver;
            }
        }     

        private void comboUserType_Enter(object sender, EventArgs e)
        {
            comboUserType.ForeColor = Color.Black;
        }

        private void comboUserType_Leave(object sender, EventArgs e)
        {
            //if (comboUserType.Text == "Select User Type")
                //comboUserType.ForeColor = Color.Silver;
        }

        private void txtShift_Enter(object sender, EventArgs e)
        {
            if (txtShift.Text == "Shift (Librarian Only)")
                txtShift.Clear();
            txtShift.ForeColor = Color.Black;
        }

        private void txtShift_Leave(object sender, EventArgs e)
        {
            if (txtShift.Text == "")
            {
                txtShift.Text = "Shift (Librarian Only)";
                txtShift.ForeColor = Color.Silver;
            }
        }

        #endregion

        #region Button_Click_Region

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            dob = dateTimePicker1.Value.ToString();       
            try
            {
                userType = comboUserType.SelectedItem.ToString();
                if (userType == "Student")
                {
                    SignUpQuery(userType, "st");
                }

                else if (userType == "Faculty")
                {
                    SignUpQuery(userType, "t");
                }

                else if (userType == "Librarian")
                {
                    SignUpQuery(userType, "L");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select User Type");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            txtID.Visible = false;
            txtName.Text = "Full Name";
            txtName.ForeColor = Color.Silver;
            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Silver;
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Silver;
            txtDepartment.Text = "Department";
            txtDepartment.ForeColor = Color.Silver;
            txtMobNo.Text = "Mobile Number";
            txtMobNo.ForeColor = Color.Silver;
            txtAddress.Text = "Address";
            txtAddress.ForeColor = Color.Silver;            
            txtShift.Text = "Shift (Librarian Only)";
            txtShift.ForeColor = Color.Silver;
            comboUserType.Text = "Select User Type";
            comboUserType.ForeColor = Color.Silver;
           
        }

        #endregion

        #region Methods
        private int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 999);
        }

        private void SignUpQuery(string userType, string idType)
        {
            if (userType == "Librarian")
            {
                string id = idType + (000 + RandomNumber()) + "" + DateTime.Today.Day;
                string query = "insert into User_Information values('" + id + "','" + txtName.Text + "','null','" + txtMobNo.Text + "', '" + txtAddress.Text + "', '" + dob + "', '" + txtEmail.Text + "', '" + userType + "')";
                DataAccess.ExecuteQuery(query);
                query = "insert into Librarian values('" + id + "','" + txtName.Text + "','"+txtShift.Text+"')";
                DataAccess.ExecuteQuery(query);
                query = "insert into AllUser values('" + id + "','" + txtPassword.Text + "','"+ userType + "')";
                DataAccess.ExecuteQuery(query);
                txtID.ForeColor = Color.Black;
                txtID.Visible = true;
                txtID.Text = "Your id : " + id;
                MessageBox.Show("Your id is : " + id);
            }
            else
            {
                string id = idType + (000 + RandomNumber()) + "" + DateTime.Today.Day;
                string query = "insert into User_Information values('" + id + "','" + txtName.Text + "','" + txtDepartment.Text + "','" + txtMobNo.Text + "', '" + txtAddress.Text + "', '" + dob + "', '" + txtEmail.Text + "', '" + userType + "')";
                DataAccess.ExecuteQuery(query);
                query = "insert into "+userType+" values('" + id + "','" + txtName.Text + "','" + txtDepartment.Text + "','Valid')";
                DataAccess.ExecuteQuery(query);
                query = "insert into AllUser values('" + id + "','" + txtPassword.Text + "','"+ userType + "')";
                DataAccess.ExecuteQuery(query);
                txtID.ForeColor = Color.Black;
                txtID.Visible = true;
                txtID.Text = "Your id : " + id;
                MessageBox.Show("Your id is : " + id);
            }
        }
        #endregion
    }
}
