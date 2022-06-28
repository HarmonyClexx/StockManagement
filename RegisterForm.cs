using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace StockManagement
{
    public partial class RegisterForm : Form
    {
        string path = "Data Source=DESKTOP-APNN3FD\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        public RegisterForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Text=="" || textConfirmPassword.Text=="" || textEmail.Text=="" || textPhone.Text=="" || textName.Text=="")
            {
                MessageBox.Show("All the fields should be filled");
            }
            else
            {
                if (textPassword.Text == textConfirmPassword.Text)
                {
                    con.Open();
                    cmd = new SqlCommand("insert into gelogin (Username, FullName, Password, Email, Phone) values('"+ textUsername.Text + "', '" + textName.Text + "', '"+ textPassword.Text + "', '"+ textEmail.Text + "', '"+ textPhone.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //Use streamWriter if you dont have a database
                    /* using (StreamWriter streamWriter = new StreamWriter("loginDetails.txt"))
                     {
                         streamWriter.WriteLine(username);
                         streamWriter.WriteLine(password);
                     }*/

                    MessageBox.Show("Your login details have been saved, now LOG IN");
                    new LoginForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("the passwords do not match, try again");

                    textPassword.Clear();
                    textConfirmPassword.Clear();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
            textConfirmPassword.Clear();
            textUsername.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
