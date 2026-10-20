namespace s1132343
{
    partial class FrmRegister
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
            groupBox1 = new GroupBox();
            chkVaccined = new CheckBox();
            groupBox2 = new GroupBox();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            numBirdAge = new NumericUpDown();
            label3 = new Label();
            cmbBirdSpecies = new ComboBox();
            txtBirdName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtOwnerAddress = new TextBox();
            txtOwnerPhone = new TextBox();
            label4 = new Label();
            txtOwnerName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnSubmitRegister = new Button();
            btnResetForm = new Button();
            btnBackToMain = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBirdAge).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkVaccined);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(numBirdAge);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbBirdSpecies);
            groupBox1.Controls.Add(txtBirdName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "【 鳥寶基本資料 】";
            // 
            // chkVaccined
            // 
            chkVaccined.AutoSize = true;
            chkVaccined.Location = new Point(219, 131);
            chkVaccined.Name = "chkVaccined";
            chkVaccined.Size = new Size(277, 23);
            chkVaccined.TabIndex = 7;
            chkVaccined.Text = "是否已接種過鸚鵡專門疫苗/健康檢查";
            chkVaccined.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoFemale);
            groupBox2.Controls.Add(rdoMale);
            groupBox2.Location = new Point(219, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(189, 80);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "【 鳥寶性別 】";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(97, 35);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(75, 23);
            rdoFemale.TabIndex = 1;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "小美女";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(16, 35);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 23);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "小帥哥";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // numBirdAge
            // 
            numBirdAge.Location = new Point(75, 133);
            numBirdAge.Name = "numBirdAge";
            numBirdAge.Size = new Size(111, 27);
            numBirdAge.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 135);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 4;
            label3.Text = "年齡 :";
            // 
            // cmbBirdSpecies
            // 
            cmbBirdSpecies.FormattingEnabled = true;
            cmbBirdSpecies.Items.AddRange(new object[] { "金剛鸚鵡", "巴丹鸚鵡", "鳳頭鸚鵡", "灰鸚鵡", "亞馬遜鸚鵡", "吸蜜鸚鵡", "金/小太陽鸚鵡", "虎皮鸚鵡", "和尚鸚鵡", "折衷鸚鵡", "凱克鸚鵡", "愛情鳥鸚鵡", "太平洋鸚鵡", "月輪鸚鵡", "玄鳳鸚鵡", "其他" });
            cmbBirdSpecies.Location = new Point(75, 84);
            cmbBirdSpecies.Name = "cmbBirdSpecies";
            cmbBirdSpecies.Size = new Size(111, 27);
            cmbBirdSpecies.TabIndex = 3;
            // 
            // txtBirdName
            // 
            txtBirdName.Location = new Point(75, 37);
            txtBirdName.Name = "txtBirdName";
            txtBirdName.Size = new Size(111, 27);
            txtBirdName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "品種 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 0;
            label1.Text = "名字 :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtOwnerAddress);
            groupBox3.Controls.Add(txtOwnerPhone);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtOwnerName);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(12, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(502, 133);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "【 飼主聯絡資料 】";
            // 
            // txtOwnerAddress
            // 
            txtOwnerAddress.Location = new Point(105, 83);
            txtOwnerAddress.Name = "txtOwnerAddress";
            txtOwnerAddress.Size = new Size(373, 27);
            txtOwnerAddress.TabIndex = 9;
            // 
            // txtOwnerPhone
            // 
            txtOwnerPhone.Location = new Point(344, 37);
            txtOwnerPhone.Name = "txtOwnerPhone";
            txtOwnerPhone.Size = new Size(134, 27);
            txtOwnerPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 86);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 4;
            label4.Text = "通訊地址：";
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(105, 37);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(134, 27);
            txtOwnerName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 40);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 1;
            label5.Text = "聯絡電話：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 40);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 0;
            label6.Text = "家長姓名 :";
            // 
            // btnSubmitRegister
            // 
            btnSubmitRegister.Location = new Point(203, 359);
            btnSubmitRegister.Name = "btnSubmitRegister";
            btnSubmitRegister.Size = new Size(110, 31);
            btnSubmitRegister.TabIndex = 2;
            btnSubmitRegister.Text = "確認送出登記";
            btnSubmitRegister.UseVisualStyleBackColor = true;
            btnSubmitRegister.Click += btnSubmitRegister_Click;
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(12, 359);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(110, 31);
            btnResetForm.TabIndex = 3;
            btnResetForm.Text = "重新填寫";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += btnResetForm_Click;
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(404, 359);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(110, 31);
            btnBackToMain.TabIndex = 4;
            btnBackToMain.Text = "返回首頁";
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(528, 403);
            Controls.Add(btnBackToMain);
            Controls.Add(btnResetForm);
            Controls.Add(btnSubmitRegister);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FrmRegister";
            Text = "鳥寶資料登記";
            Load += FrmRegister_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBirdAge).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbBirdSpecies;
        private TextBox txtBirdName;
        private Label label2;
        private Label label1;
        private CheckBox chkVaccined;
        private GroupBox groupBox2;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private NumericUpDown numBirdAge;
        private Label label3;
        private GroupBox groupBox3;
        private TextBox txtOwnerAddress;
        private TextBox txtOwnerPhone;
        private Label label4;
        private TextBox txtOwnerName;
        private Label label5;
        private Label label6;
        private Button btnSubmitRegister;
        private Button btnResetForm;
        private Button btnBackToMain;
    }
}