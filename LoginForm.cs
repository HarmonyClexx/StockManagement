using System.Data;
using System.Data.SqlClient;

namespace StockManagement
{
    public partial class LoginForm : Form
    {
        string path = "Data Source=DESKTOP-APNN3FD\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;

        public LoginForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select count(*) from gelogin where username='"+textUsername.Text+ "' and password='"+textPassword.Text+ "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(textUsername.Text == "")
            {
                MessageBox.Show("Username must not be empty!!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (textPassword.Text == "")
            {
                MessageBox.Show("Password must not be empty!!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    new SplashScreen().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The username or Password is not correct, try again");
                    textUsername.Clear();
                    textPassword.Clear();
                    textUsername.Focus();
                }
            }
            
            //Using StreamReader if you dont hvae a database
            /* if (File.Exists("loginDetails.txt"))
             {
                 using(StreamReader streamReader = new StreamReader("loginDetails.txt"))
                 {
                     if (textUsername.Text == streamReader.ReadLine() && textPassword.Text == streamReader.ReadLine())
                     {
                         new DashboardForm().Show();
                         this.Hide();
                     }
                     else
                     {
                         MessageBox.Show("The username or Password is not correct, try again");
                         textUsername.Clear();
                         textPassword.Clear();
                         textUsername.Focus();
                     }
                 }
             }*/
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
            textUsername.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == false)
            {
                textPassword.UseSystemPasswordChar=false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}