using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockManagement
{
    public partial class ReportForm : Form
    {
        string path = "Data Source=DESKTOP-APNN3FD\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        public ReportForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            DisplayData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            //var updateQuery = "";
            dt = new DataTable();

            if (textSearch.Text == "")
            {
                MessageBox.Show("please type what you want to search!");
            }
            else
            {
                

                if (AlreadyExist(con, textSearch.Text))
                {
                    sda = new SqlDataAdapter("SELECT * FROM Stocks WHERE Category= '" + textSearch.Text + "'", con);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    

                }
                else
                {
                    MessageBox.Show("Item name DOES NOT exist\n You can go to home window and add the Record");
                }
               
            }
            con.Close();
        }

        public void DisplayData()
        {
            dt = new DataTable();
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM Stocks", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DashboardForm().Show();
            this.Hide();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private bool AlreadyExist(SqlConnection con, string category)
        {
            sda = new SqlDataAdapter("select 1 from Stocks WHERE Category= '" + category + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void changeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DisplayView().Show();
            this.Hide();
        }
    }
}
