namespace s1132343
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            timerTitle = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            首頁ToolStripMenuItem = new ToolStripMenuItem();
            menuSpecies = new ToolStripMenuItem();
            menuHabits = new ToolStripMenuItem();
            menuCalculator = new ToolStripMenuItem();
            menuRegister = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("微軟正黑體", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblTitle.Location = new Point(96, 82);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(505, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "歡迎來到鸚鵡小天地！";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // timerTitle
            // 
            timerTitle.Enabled = true;
            timerTitle.Interval = 300;
            timerTitle.Tick += timerTitle_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("微軟正黑體", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 首頁ToolStripMenuItem, menuSpecies, menuHabits, menuCalculator, menuRegister, menuExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(691, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // 首頁ToolStripMenuItem
            // 
            首頁ToolStripMenuItem.Name = "首頁ToolStripMenuItem";
            首頁ToolStripMenuItem.Size = new Size(58, 26);
            首頁ToolStripMenuItem.Text = "首頁";
            // 
            // menuSpecies
            // 
            menuSpecies.AccessibleRole = AccessibleRole.MenuBar;
            menuSpecies.Name = "menuSpecies";
            menuSpecies.Size = new Size(126, 26);
            menuSpecies.Text = "鸚鵡百科全書";
            menuSpecies.Click += btnGoSpecies_Click;
            // 
            // menuHabits
            // 
            menuHabits.Name = "menuHabits";
            menuHabits.Size = new Size(143, 26);
            menuHabits.Text = "鸚鵡習性與測驗";
            menuHabits.Click += btnGoHabits_Click;
            // 
            // menuCalculator
            // 
            menuCalculator.Name = "menuCalculator";
            menuCalculator.Size = new Size(143, 26);
            menuCalculator.Text = "鳥奴購物計算器";
            menuCalculator.Click += btnGoCalc_Click;
            // 
            // menuRegister
            // 
            menuRegister.Name = "menuRegister";
            menuRegister.Size = new Size(126, 26);
            menuRegister.Text = "鳥寶資料登記";
            menuRegister.Click += menuRegister_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(58, 26);
            menuExit.Text = "離開";
            menuExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.第三圖;
            pictureBox1.Location = new Point(0, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.第四圖要去背;
            pictureBox2.Location = new Point(576, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 147);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(691, 176);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "首頁";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private System.Windows.Forms.Timer timerTitle;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSpecies;
        private ToolStripMenuItem menuHabits;
        private ToolStripMenuItem menuCalculator;
        private ToolStripMenuItem menuRegister;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem 首頁ToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}