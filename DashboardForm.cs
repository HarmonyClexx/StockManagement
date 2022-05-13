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
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace StockManagement
{
    public partial class DashboardForm : Form
    {
        
        string path = "Data Source=DESKTOP-APNN3FD\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;

        DataTable table = new DataTable();
        int index;
        public DashboardForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure you want to Close  the application?\n\n Your data was already saved",
                "Warning!! App Closing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //
                Application.Exit();
            }
           
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            var updateQuery = "";

            if (AlreadyExist(con, textId.Text))
            {
                updateQuery = @"UPDATE Stocks SET Item_Name= '" + textName.Text + "', Brand= '"+textBrand.Text+"', Price= '" + textPrice.Text + "', Quantity= '" + textQuantity.Text + "', Category= '" + textCategory.Text + "' WHERE Item_ID= '" + textId.Text + "'";
                DataGridViewRow newdata = dataGridView1.Rows[index];
                newdata.Cells[0].Value = textId.Text;
                newdata.Cells[1].Value = textName.Text;
                newdata.Cells[2].Value = textBrand.Text;
                newdata.Cells[3].Value = textPrice.Text;
                newdata.Cells[4].Value = textQuantity.Text;
                newdata.Cells[5].Value = textCategory.Text;
            }
            else
            {
                updateQuery = @"insert into Stocks (Item_ID, Item_Name, Brand, Price, Quantity, Category) values ('" + textId.Text + "', '" + textName.Text + "', '"+textBrand.Text+"', '" + textPrice.Text + "', '" + textQuantity.Text + "', '" + textCategory.Text + "')";
                DataGridViewRow newdata = dataGridView1.Rows[index];
                newdata.Cells[0].Value = textId.Text;
                newdata.Cells[1].Value = textName.Text;
                newdata.Cells[2].Value = textBrand.Text;
                newdata.Cells[3].Value = textPrice.Text;
                newdata.Cells[4].Value = textQuantity.Text;
                newdata.Cells[5].Value = textCategory.Text;
            }
            cmd = new SqlCommand(updateQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Item_ID", Type.GetType("System.Int32"));
            table.Columns.Add("Item_Name", Type.GetType("System.String"));
            table.Columns.Add("Brand", Type.GetType("System.String"));
            table.Columns.Add("Price", Type.GetType("System.Int32"));
            table.Columns.Add("Quantity", Type.GetType("System.Int32"));
            table.Columns.Add("Category", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int outID;
            int outPrice;
            int outQuantity;
            con.Open();
            var updateQuery = "";

            if (!int.TryParse(textId.Text, out outID)|| textId.Text=="")
            {   
                MessageBox.Show("Item ID must be integer\nAND must not be empty!!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textId.Clear();
                textId.Focus();
            }
            else if (textName.Text == "")
            {
                MessageBox.Show("Item Name must not be empty!!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textName.Clear();
                textName.Focus();
            }
            else if (textBrand.Text == "")
            {
                MessageBox.Show("Item Name must not be empty!!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBrand.Clear();
                textBrand.Focus();
            }
            else if (textCategory.Text == "")
            {
                MessageBox.Show("Item category must not be empty!!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCategory.Clear();
                textCategory.Focus();
            }
            else if (!int.TryParse(textPrice.Text, out outPrice) || textPrice.Text=="")
            {
                MessageBox.Show("Item price must be int\nAND must not be empty!!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPrice.Clear();
                textPrice.Focus();
            }else if (!int.TryParse(textQuantity.Text, out outQuantity) || textQuantity.Text=="")
            {
                MessageBox.Show("Quantity of items must be int\nAND must not be empty!!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textQuantity.Clear();
                textQuantity.Focus();
            } 
            else
            {
                if (AlreadyExist(con, textId.Text))
                {
                    
                    updateQuery = @"UPDATE Stocks SET Item_Name= '" + textName.Text + "', Brand= '"+textBrand.Text+"', Price= '" + textPrice.Text + "', Quantity= '" + textQuantity.Text + "', Category= '" + textCategory.Text + "' WHERE Item_ID= '" + textId.Text + "'";
                    
                    table.Rows.Add(textId.Text, textName.Text, textBrand.Text, textPrice.Text, textQuantity.Text, textCategory.Text);
                    textId.Clear();
                    textName.Clear();
                    textBrand.Clear();
                    textPrice.Clear();
                    textQuantity.Clear();
                    textCategory.Clear();



                }
                else
                {
                    updateQuery = @"insert into Stocks (Item_ID, Item_Name, Brand, Price, Quantity, Category) values ('" + textId.Text + "', '" + textName.Text + "', '"+textBrand.Text+"', '" + textPrice.Text + "', '" + textQuantity.Text + "', '" + textCategory.Text + "')";

                    table.Rows.Add(textId.Text, textName.Text, textBrand.Text, textPrice.Text, textQuantity.Text, textCategory.Text);
                    textId.Clear();
                    textName.Clear();
                    textBrand.Clear();
                    textPrice.Clear();
                    textQuantity.Clear();
                    textCategory.Clear();
                }
                cmd = new SqlCommand(updateQuery, con);
                cmd.ExecuteNonQuery();
            }           
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textId.Text = row.Cells[0].Value.ToString();
            textName.Text = row.Cells[1].Value.ToString();
            textBrand.Text = row.Cells[2].Value.ToString();
            textPrice.Text = row.Cells[3].Value.ToString();
            textQuantity.Text = row.Cells[4].Value.ToString();
            textCategory.Text = row.Cells[5].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            var updateQuery = "";

            if (AlreadyExist(con, textId.Text))
            {
                updateQuery = @"DELETE FROM Stocks WHERE Item_ID= '" + textId.Text + "'";
                cmd = new SqlCommand(updateQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Record does not exist, please check entered details");
            }
            
        }

        private bool AlreadyExist(SqlConnection con, string Item_ID)
        {
            sda = new SqlDataAdapter("select 1 from Stocks WHERE Item_ID= '"+ Item_ID + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textId.Clear();
            textName.Clear();
            textBrand.Clear();
            textPrice.Clear();
            textQuantity.Clear();
            textCategory.Clear();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();
            this.Hide();
        }

        public void DisplayData()
        {
            DataTable dt;
            dt = new DataTable();
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM Stocks", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure you want to display all data?\n because it can be tempered with",
                "Warning!! Data about to be displayed", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //
                DisplayData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
        }

        private void categoryModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DisplayView().Show();
            this.Hide();
        }
    }
}
