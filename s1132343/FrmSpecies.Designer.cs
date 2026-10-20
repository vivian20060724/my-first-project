namespace s1132343
{
    partial class FrmSpecies
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
            lstSpecies = new ListBox();
            picParrot = new PictureBox();
            txtIntro = new TextBox();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picParrot).BeginInit();
            SuspendLayout();
            // 
            // lstSpecies
            // 
            lstSpecies.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lstSpecies.FormattingEnabled = true;
            lstSpecies.ItemHeight = 25;
            lstSpecies.Items.AddRange(new object[] { "巴丹鸚鵡", "金剛鸚鵡", "灰鸚鵡", "凱克鸚鵡", "和尚鸚鵡", "小太陽鸚鵡", "玄鳳鸚鵡", "虎皮鸚鵡", "愛情鳥" });
            lstSpecies.Location = new Point(23, 54);
            lstSpecies.Name = "lstSpecies";
            lstSpecies.Size = new Size(131, 79);
            lstSpecies.TabIndex = 0;
            lstSpecies.SelectedIndexChanged += lstSpecies_SelectedIndexChanged;
            // 
            // picParrot
            // 
            picParrot.BackColor = Color.Ivory;
            picParrot.Image = Properties.Resources.愛情鳥鸚鵡;
            picParrot.Location = new Point(298, 42);
            picParrot.Name = "picParrot";
            picParrot.Size = new Size(439, 330);
            picParrot.SizeMode = PictureBoxSizeMode.Zoom;
            picParrot.TabIndex = 1;
            picParrot.TabStop = false;
            picParrot.Click += picParrot_Click;
            // 
            // txtIntro
            // 
            txtIntro.Location = new Point(14, 160);
            txtIntro.Multiline = true;
            txtIntro.Name = "txtIntro";
            txtIntro.ReadOnly = true;
            txtIntro.ScrollBars = ScrollBars.Vertical;
            txtIntro.Size = new Size(256, 237);
            txtIntro.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(181, 82);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 51);
            btnBack.TabIndex = 3;
            btnBack.Text = "返回首頁";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(232, 29);
            label1.TabIndex = 4;
            label1.Text = "請選擇想認識的鸚鵡 :";
            // 
            // FrmSpecies
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(753, 417);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(txtIntro);
            Controls.Add(picParrot);
            Controls.Add(lstSpecies);
            Name = "FrmSpecies";
            Text = "鸚鵡品種大百科";
            Load += FrmSpecies_Load;
            ((System.ComponentModel.ISupportInitialize)picParrot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSpecies;
        private PictureBox picParrot;
        private TextBox txtIntro;
        private Button btnBack;
        private Label label1;
    }
}