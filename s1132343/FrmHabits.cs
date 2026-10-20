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
    public partial class FrmHabits : Form
    {
        public FrmHabits()
        {
            InitializeComponent();
        }

        private void lblHabit1_Click(object sender, EventArgs e)
        {

        }

        private void FrmHabits_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. 宣告一個整數變數（計數器），用來記錄使用者總共勾選了幾項符合的條件
            int scoreCount = 0;

            // 2. 利用標準的 for 迴圈，逐一檢查 CheckedListBox 裡面的每一個項目是否被勾選
            // chkQuiz.Items.Count 代表我們在畫面上輸入的 8 個測驗題目總數
            for (int i = 0; i < chkQuiz.Items.Count; i++)
            {
                // chkQuiz.GetItemChecked(i) 如果回傳 true，代表該項目有被打了勾勾
                if (chkQuiz.GetItemChecked(i) == true)
                {
                    // 計數器累加 1
                    scoreCount = scoreCount + 1;
                }
            }

            // 3. 根據使用者最後勾選的數量（得分），利用 if-else 分流給予不同的趣味評語與精美彈窗
            if (scoreCount == chkQuiz.Items.Count)
            {
                // 如果 8 項滿分全部勾選
                MessageBox.Show("【完美鳥奴！】\r\n\r\n恭喜你！你已經做好了完美的心理準備與環境評估，你一定能成為一隻幸福鸚鵡的最佳夥伴！");
            }
            else if (scoreCount >= 5)
            {
                // 如果勾選了 5 到 7 項
                MessageBox.Show($"【潛力新星】\r\n\r\n您總共勾選了 {scoreCount} 個項目。您已經具備了基本的飼育觀念，但針對那些還沒勾選的項目，建議再深思熟慮，或與家人室友多加討論喔！");
            }
            else if (scoreCount >= 1)
            {
                // 如果只勾選了 1 到 4 項
                MessageBox.Show($"【需要再想想】\r\n\r\n您目前僅符合 {scoreCount} 個項目。盲目飼養可能會讓您與鳥鳥未來都很痛苦，建議多做一些功課、重新評估環境後再做決定！");
            }
            else
            {
                // 一項都沒有勾選
                MessageBox.Show("【請勿衝動！】\r\n\r\n您一項都沒有勾選。千萬不要因為一時覺得影片裡的鸚鵡很可愛就衝動帶牠們回家喔！養鳥是一輩子的責任。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // 關閉當前的 FrmHabits 視窗，程式就會自動帶你回到剛剛的主選單 (FrmMain) 囉！
            this.Close();
        }
    }
}
