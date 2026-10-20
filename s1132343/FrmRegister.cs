using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1132343
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        // 當登記表單載入時
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            // 設定視窗開啟時自動置中
            this.StartPosition = FormStartPosition.CenterScreen;

            // 預設選取第一個品種（金剛鸚鵡）
            if (cmbBirdSpecies.Items.Count > 0)
            {
                cmbBirdSpecies.SelectedIndex = 0;
            }

            // 設定數字上下鈕 (NumericUpDown) 的範圍（鸚鵡年齡 0 歲到 100 歲）
            numBirdAge.Minimum = 0;
            numBirdAge.Maximum = 100;
            numBirdAge.Value = 0; // 預設 0 歲

            // 預設勾選鳥寶性別為男寶寶
            rdoMale.Checked = true;
        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            // 1. 嚴格的安全防錯檢查
            if (txtBirdName.Text.Trim() == "")
            {
                MessageBox.Show("請輸入鳥寶（鸚鵡）的名字！", "資料未填", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOwnerName.Text.Trim() == "")
            {
                MessageBox.Show("請輸入家長姓名！", "資料未填", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOwnerPhone.Text.Trim() == "")
            {
                MessageBox.Show("請輸入家長的聯絡電話！", "資料未填", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOwnerAddress.Text.Trim() == "")
            {
                MessageBox.Show("請輸入通訊地址！", "資料未填", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. 收集鳥寶性別
            string birdGender = "";
            if (rdoMale.Checked == true)
            {
                birdGender = "公 ";
            }
            else
            {
                birdGender = "母";
            }

            // 3. 收集疫苗勾選狀態
            string vaccineStatus = "";
            if (chkVaccined.Checked == true)
            {
                vaccineStatus = "已接種疫苗 / 健康檢查";
            }
            else
            {
                vaccineStatus = "尚未接種疫苗 / 健康檢查";
            }

            // 4. 抓取所有控制項填寫的內容
            string birdName = txtBirdName.Text;
            string birdSpecies = cmbBirdSpecies.SelectedItem.ToString();
            int birdAge = (int)numBirdAge.Value;
            string ownerName = txtOwnerName.Text;
            string ownerPhone = txtOwnerPhone.Text;
            string ownerAddress = txtOwnerAddress.Text;

            // 5. 成果展現：將新名單收集到的資料整齊排版串接
            string summaryMessage = "【 鳥寶身份登記成功 】\r\n\r\n" +
                                    $"◆ 鳥寶姓名：{birdName}\r\n" +
                                    $"◆ 鳥寶品種：{birdSpecies}\r\n" +
                                    $"◆ 鳥寶性別：{birdGender}\r\n" +
                                    $"◆ 鳥寶年齡：{birdAge} 歲\r\n" +
                                    $"◆ 疫苗狀態：{vaccineStatus}\r\n" +
                                    "------------------------------------------\r\n" +
                                    $"◆ 家長姓名：{ownerName}\r\n" +
                                    $"◆ 聯絡電話：{ownerPhone}\r\n" +
                                    $"◆ 通訊地址：{ownerAddress}\r\n\r\n" +
                                    "恭喜您！建檔資料已成功儲存至系統中。";

            MessageBox.Show(summaryMessage, "登記建檔成功");
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            txtBirdName.Text = "";
            txtOwnerName.Text = "";
            txtOwnerPhone.Text = "";
            txtOwnerAddress.Text = "";

            if (cmbBirdSpecies.Items.Count > 0) cmbBirdSpecies.SelectedIndex = 0;
            numBirdAge.Value = 0;
            rdoMale.Checked = true;
            chkVaccined.Checked = false;

            MessageBox.Show("表單已重設，請重新輸入資料。", "重設提示");
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
