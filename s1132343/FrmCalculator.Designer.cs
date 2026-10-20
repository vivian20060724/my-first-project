namespace s1132343
{
    partial class FrmCalculator
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
            label1 = new Label();
            lstCategory = new ListBox();
            lstProducts = new ListBox();
            lstCart = new ListBox();
            label3 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            lblResult = new Label();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 0;
            label1.Text = "選擇種類：";
            // 
            // lstCategory
            // 
            lstCategory.FormattingEnabled = true;
            lstCategory.ItemHeight = 22;
            lstCategory.Items.AddRange(new object[] { "飼料", "站棍", "站台", "保健食品", "玩具", "籠子", "文藝商品" });
            lstCategory.Location = new Point(31, 44);
            lstCategory.Name = "lstCategory";
            lstCategory.Size = new Size(235, 180);
            lstCategory.TabIndex = 1;
            lstCategory.SelectedIndexChanged += lstCategory_SelectedIndexChanged;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 22;
            lstProducts.Location = new Point(294, 44);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(235, 180);
            lstProducts.TabIndex = 2;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // lstCart
            // 
            lstCart.FormattingEnabled = true;
            lstCart.ItemHeight = 22;
            lstCart.Location = new Point(31, 261);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(432, 92);
            lstCart.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(294, 19);
            label3.Name = "label3";
            label3.Size = new Size(95, 22);
            label3.TabIndex = 5;
            label3.Text = "選擇商品：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(30, 236);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 6;
            label2.Text = "你的購物車:";
            label2.Click += label2_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(487, 270);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(42, 70);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "結\r\n帳";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblResult.Location = new Point(79, 383);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(109, 22);
            lblResult.TabIndex = 8;
            lblResult.Text = "總金額：0 元";
            lblResult.Click += lblResult_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(315, 378);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 32);
            btnClear.TabIndex = 9;
            btnClear.Text = "清空";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(425, 378);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 32);
            btnBack.TabIndex = 10;
            btnBack.Text = "返回首頁";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(564, 423);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lstCart);
            Controls.Add(lstProducts);
            Controls.Add(lstCategory);
            Controls.Add(label1);
            Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "FrmCalculator";
            Text = "購物計算器";
            Load += FrmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstCategory;
        private ListBox lstProducts;
        private ListBox lstCart;
        private Label label3;
        private Label label2;
        private Button btnCalculate;
        private Label lblResult;
        private Button btnClear;
        private Button btnBack;
    }
}