namespace StockManagement
{
    partial class DisplayView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCouch = new System.Windows.Forms.Button();
            this.buttonBed = new System.Windows.Forms.Button();
            this.buttonWardrobe = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonFridge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTv = new System.Windows.Forms.Button();
            this.buttonKettle = new System.Windows.Forms.Button();
            this.buttonMicrowave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCouch);
            this.panel1.Controls.Add(this.buttonBed);
            this.panel1.Controls.Add(this.buttonWardrobe);
            this.panel1.Controls.Add(this.buttonStand);
            this.panel1.Controls.Add(this.buttonTable);
            this.panel1.Controls.Add(this.buttonFridge);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonTv);
            this.panel1.Controls.Add(this.buttonKettle);
            this.panel1.Controls.Add(this.buttonMicrowave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 428);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonCouch
            // 
            this.buttonCouch.Image = global::StockManagement.Properties.Resources.image488;
            this.buttonCouch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCouch.Location = new System.Drawing.Point(4, 333);
            this.buttonCouch.Name = "buttonCouch";
            this.buttonCouch.Size = new System.Drawing.Size(108, 23);
            this.buttonCouch.TabIndex = 11;
            this.buttonCouch.Text = "Couches";
            this.buttonCouch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCouch.UseVisualStyleBackColor = true;
            this.buttonCouch.Click += new System.EventHandler(this.buttonCouch_Click);
            // 
            // buttonBed
            // 
            this.buttonBed.Image = global::StockManagement.Properties.Resources.image476;
            this.buttonBed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBed.Location = new System.Drawing.Point(2, 304);
            this.buttonBed.Name = "buttonBed";
            this.buttonBed.Size = new System.Drawing.Size(108, 23);
            this.buttonBed.TabIndex = 10;
            this.buttonBed.Text = "Beds";
            this.buttonBed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBed.UseVisualStyleBackColor = true;
            this.buttonBed.Click += new System.EventHandler(this.buttonBed_Click);
            // 
            // buttonWardrobe
            // 
            this.buttonWardrobe.Image = global::StockManagement.Properties.Resources.image464;
            this.buttonWardrobe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWardrobe.Location = new System.Drawing.Point(3, 275);
            this.buttonWardrobe.Name = "buttonWardrobe";
            this.buttonWardrobe.Size = new System.Drawing.Size(108, 23);
            this.buttonWardrobe.TabIndex = 9;
            this.buttonWardrobe.Text = "Wardrobes";
            this.buttonWardrobe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWardrobe.UseVisualStyleBackColor = true;
            this.buttonWardrobe.Click += new System.EventHandler(this.buttonWardrobe_Click);
            // 
            // buttonStand
            // 
            this.buttonStand.Image = global::StockManagement.Properties.Resources.image452;
            this.buttonStand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStand.Location = new System.Drawing.Point(3, 246);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(108, 23);
            this.buttonStand.TabIndex = 8;
            this.buttonStand.Text = "TV Stands";
            this.buttonStand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStand.UseVisualStyleBackColor = true;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.Image = global::StockManagement.Properties.Resources.image440;
            this.buttonTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTable.Location = new System.Drawing.Point(3, 217);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(108, 23);
            this.buttonTable.TabIndex = 7;
            this.buttonTable.Text = "Tables";
            this.buttonTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonFridge
            // 
            this.buttonFridge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFridge.Image = global::StockManagement.Properties.Resources.fridge1;
            this.buttonFridge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFridge.Location = new System.Drawing.Point(4, 26);
            this.buttonFridge.Name = "buttonFridge";
            this.buttonFridge.Size = new System.Drawing.Size(108, 31);
            this.buttonFridge.TabIndex = 3;
            this.buttonFridge.Text = "Fridges";
            this.buttonFridge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFridge.UseVisualStyleBackColor = true;
            this.buttonFridge.Click += new System.EventHandler(this.buttonFridge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Furniture";
            // 
            // buttonTv
            // 
            this.buttonTv.Image = global::StockManagement.Properties.Resources.image428;
            this.buttonTv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTv.Location = new System.Drawing.Point(4, 128);
            this.buttonTv.Name = "buttonTv";
            this.buttonTv.Size = new System.Drawing.Size(108, 27);
            this.buttonTv.TabIndex = 6;
            this.buttonTv.Text = "Televisions";
            this.buttonTv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTv.UseVisualStyleBackColor = true;
            this.buttonTv.Click += new System.EventHandler(this.buttonTv_Click);
            // 
            // buttonKettle
            // 
            this.buttonKettle.Image = global::StockManagement.Properties.Resources.image301;
            this.buttonKettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKettle.Location = new System.Drawing.Point(4, 91);
            this.buttonKettle.Name = "buttonKettle";
            this.buttonKettle.Size = new System.Drawing.Size(108, 31);
            this.buttonKettle.TabIndex = 5;
            this.buttonKettle.Text = "Kettles";
            this.buttonKettle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKettle.UseVisualStyleBackColor = true;
            this.buttonKettle.Click += new System.EventHandler(this.buttonKettle_Click);
            // 
            // buttonMicrowave
            // 
            this.buttonMicrowave.Image = global::StockManagement.Properties.Resources.image101;
            this.buttonMicrowave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMicrowave.Location = new System.Drawing.Point(4, 63);
            this.buttonMicrowave.Name = "buttonMicrowave";
            this.buttonMicrowave.Size = new System.Drawing.Size(108, 22);
            this.buttonMicrowave.TabIndex = 4;
            this.buttonMicrowave.Text = "Microwaves";
            this.buttonMicrowave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMicrowave.UseVisualStyleBackColor = true;
            this.buttonMicrowave.Click += new System.EventHandler(this.buttonMicrowave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apliances";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockReportToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.stockReportToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(149, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upload Category pictures here";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(355, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 426);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(371, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 425);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textCategory
            // 
            this.textCategory.Location = new System.Drawing.Point(149, 97);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(166, 23);
            this.textCategory.TabIndex = 6;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(197, 136);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(118, 23);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "Browse and upload";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(802, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Brands available:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(802, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 150);
            this.listBox1.TabIndex = 17;
            // 
            // DisplayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 452);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DisplayView";
            this.Text = "DisplayView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button buttonCouch;
        private Button buttonBed;
        private Button buttonWardrobe;
        private Button buttonStand;
        private Button buttonTable;
        private Button buttonTv;
        private Button buttonKettle;
        private Button buttonMicrowave;
        private Button buttonFridge;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stockReportToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textCategory;
        private Button buttonBrowse;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Label label6;
        private ListBox listBox1;
    }
}