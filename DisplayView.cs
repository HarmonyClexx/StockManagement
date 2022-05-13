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
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Collections;
using System.Security.Cryptography;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Reflection.Emit;


namespace StockManagement
{
    public partial class DisplayView : Form
    {
        string path = "Data Source=DESKTOP-APNN3FD\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;


        public DisplayView()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //we already define our connection globaly. We are just calling the object of connection.
                    con.Open();
                    var query = "";

                    if (AlreadyExist(con, textCategory.Text))
                    {
                        query = @"UPDATE pictures SET Image = @pic WHERE Category = '" + textCategory.Text + "'";

                    }
                    else
                    {
                        query = @"insert into pictures (Category, image)values('" + textCategory.Text + "', @pic)";
                    }

                    cmd = new SqlCommand(query, con);
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    byte[] image = new byte[fs.Length];
                    fs.Read(image, 0, Convert.ToInt32(fs.Length));
                    fs.Close();

                    SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                    cmd.Parameters.Add(prm);
                    cmd.ExecuteNonQuery();

                    
                    con.Close();
                    MessageBox.Show("Image uploaded successfully.");


                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFridge_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'fridge'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks WHERE Category ='fridge' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private bool AlreadyExist(SqlConnection con, string category)
        {
            sda = new SqlDataAdapter("select 1 from pictures WHERE Category= '" + category + "'", con);
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

        private void buttonMicrowave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'microwave'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks where Category = 'microwave' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonKettle_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'kettle'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks where Category = 'kettle' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonTv_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'television'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks where Category = 'television' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'table'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks where Category = 'table' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'tvstand'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks where Category = 'tvstand' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonWardrobe_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'wardrobe'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks where Category = 'wardrobe' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonBed_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'bed'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks where Category = 'bed' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonCouch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Retrieve BLOB from database into DataSet.
                cmd = new SqlCommand("SELECT Image FROM pictures WHERE Category = 'couch'", con);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds, "pictures");
                int c = ds.Tables["pictures"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["pictures"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureBox1.Image = Image.FromStream(stmBLOBData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                cmd = new SqlCommand("SELECT DISTINCT brand FROM Stocks where Category = 'couch' ", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Brand";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DashboardForm().Show();
            this.Hide();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();
            this.Hide();
        }
    }

}
