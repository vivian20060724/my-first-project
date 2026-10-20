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
    public partial class FrmMain : Form
    {
        // 宣告一個布林變數，用來控制標題文字是要放大還是縮小
        // 這是為了配合 Timer 做心跳特效
        private bool isFontGrowing = true;
        public FrmMain()
        {
            InitializeComponent();
        }
        // 畫面的 Load 事件：當主選單一打開時會執行的動作
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 設定視窗開啟時，自動顯示在螢幕正中央
            this.StartPosition = FormStartPosition.CenterScreen;

            // 確保我們的計時器是有啟動的
            timerTitle.Start();


        }
        //百科全書
        private void btnGoSpecies_Click(object sender, EventArgs e)
        {
            // 1. 宣告並實體化品種百科的表單
            FrmSpecies speciesForm = new FrmSpecies();

            // 2. 隱藏當前的主選單表單（讓畫面比較乾淨）
            this.Hide();

            // 3. 顯示品種百科視窗（使用 ShowDialog，使用者必須先關閉新視窗才能回到這裡）
            speciesForm.ShowDialog();

            // 4. 當使用者關閉百科視窗後，程式會回到這一行，我們重新把主選單顯示出來
            this.Show();
        }
        //習性
        private void btnGoHabits_Click(object sender, EventArgs e)
        {
            // 1. 宣告並實體化習性表單
            FrmHabits habitsForm = new FrmHabits();

            // 2. 隱藏當前的主選單表單（讓畫面比較乾淨）
            this.Hide();

            // 3. 彈出習性視窗
            habitsForm.ShowDialog();

            // 4. 百科視窗關閉後，重新顯示主選單
            this.Show();
        }
        //購物計算器
        private void btnGoCalc_Click(object sender, EventArgs e)
        {
            // 1. 宣告並實體化計算器表單
            FrmCalculator calcForm = new FrmCalculator();

            // 2. 隱藏當前的主選單表單（讓畫面比較乾淨）
            this.Hide();

            // 3. 彈出計算器視窗
            calcForm.ShowDialog();

            // 4. 計算器視窗關閉後，重新顯示主選單
            this.Show();
        }
        //離開
        private void btnExit_Click(object sender, EventArgs e)
        {
            // 彈出確認視窗，詢問使用者是否真的要離開
            DialogResult result = MessageBox.Show("確定要離開鳥寶系統嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 如果使用者點選「是(Yes)」，就關閉整個程式
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //可考慮刪掉的計時
        private void timerTitle_Tick(object sender, EventArgs e)
        {
            // 1. 取得目前的字體大小
            float currentSize = lblTitle.Font.Size;

            // 2. 控制放大與縮小
            if (isFontGrowing)
            {
                currentSize += 0.5f; // 每次只放大一點點

                // 溫柔呼吸：放大到 26pt 就好
                if (currentSize >= 28f)
                {
                    isFontGrowing = false;
                }
            }
            else
            {
                currentSize -= 0.5f; // 每次只縮小一點點

                // 溫柔呼吸：縮小到 23.5pt 就換方向
                if (currentSize <= 27.5f)
                {
                    isFontGrowing = true;
                }
            }

            // 3. 將計算完的新大小，重新套用回標題 Label（維持置中狀態）
            lblTitle.Font = new Font("微軟正黑體", currentSize, FontStyle.Bold);
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            // 1. 宣告並實體化介面五（鳥寶登記）的表單
            FrmRegister registerForm = new FrmRegister();

            // 2. 彈出登記表單視窗（蓋在主選單上方）
            registerForm.ShowDialog();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
