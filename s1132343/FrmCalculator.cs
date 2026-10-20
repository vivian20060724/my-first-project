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
    public partial class FrmCalculator : Form
    {
        // 💡 課堂教過的技術：宣告一個動態陣列 (List<int>)，用來在背後悄悄記錄購物車裡每一項商品的價錢
        private List<int> cartPrices = new List<int>();
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            // 設定視窗開啟時，自動完美的顯示在螢幕正中央
            this.StartPosition = FormStartPosition.CenterScreen;

            // 預設先選取第一個分類（飼料），這樣畫面一打開中間就會有商品
            if (lstCategory.Items.Count > 0)
            {
                lstCategory.SelectedIndex = 0;
            }
        }
        // 【動作一】當使用者點選左邊不同的「大分類」時，右上角的清單會動態更新商品
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 安全檢查：如果什麼都沒選（索引值為 -1），就立刻結束，防止程式閃退
            if (lstCategory.SelectedIndex == -1) return;

            // 先把右上角的商品清單徹底清空，才不會跟舊分類的商品混在一起
            lstProducts.Items.Clear();

            // 取得目前選到的大分類文字
            string selectedCategory = lstCategory.SelectedItem.ToString();

            // 100% 老師教過的標準 if-else 分流，用 .Items.Add 一行行把商品和價格塞入右上角
            if (selectedCategory == "飼料")
            {
                lstProducts.Items.Add("滋養丸特大包 $500");
                lstProducts.Items.Add("綜合無殼穀物 $250");
                lstProducts.Items.Add("有機蔬菜乾點心 $180");
            }
            else if (selectedCategory == "站棍")
            {
                lstProducts.Items.Add("天然磨爪棲棍 $300");
                lstProducts.Items.Add("仙人掌木站棍 $450");
                lstProducts.Items.Add("微風小鳥懸掛橫木 $200");
            }
            else if (selectedCategory == "站台")
            {
                lstProducts.Items.Add("桌上型原木站台 $800");
                lstProducts.Items.Add("不鏽鋼移動式高站台 $1500");
            }
            else if (selectedCategory == "保健食品")
            {
                lstProducts.Items.Add("觀賞鳥專用電解質 $350");
                lstProducts.Items.Add("高效能綜合維他命粉 $420");
                lstProducts.Items.Add("優質水溶性生物鈣 $380");
            }
            else if (selectedCategory == "玩具")
            {
                lstProducts.Items.Add("彩色劍麻啃咬拉扯玩具 $150");
                lstProducts.Items.Add("鸚鵡益智覓食旋轉輪 $290");
                lstProducts.Items.Add("天然藤球串吊飾 $120");
            }
            else if (selectedCategory == "籠子")
            {
                lstProducts.Items.Add("一般白鐵鳥籠 $3000");
                lstProducts.Items.Add("加高型白鐵鳥籠 $3500");
            }
            else if (selectedCategory == "文藝商品")
            {
                lstProducts.Items.Add("黃和尚帆布袋 $250");
                lstProducts.Items.Add("手繪陶瓷杯墊 $150");
                lstProducts.Items.Add("傘巴鑰匙圈 $120");
            }
        }
        // 【動作二】當使用者點選右上角的「商品」時，下方的購物車「自動」加上商品與價錢
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 安全檢查：如果使用者只是點擊空白處或清空時觸發（SelectedIndex == -1），就直接離開
            if (lstProducts.SelectedIndex == -1) return;

            // 1. 取得右上角被點選的商品完整文字（例如："綜合無殼穀物 - $250"）
            string productText = lstProducts.SelectedItem.ToString();

            // 2. 直接把這行商品文字，用 .Add 丟進下方的購物車 (lstCart) 裡顯示
            lstCart.Items.Add(productText);

            // 3. 判斷價格並記錄在後台動態陣列：用最基礎、安全的 Contains 語法抓出對應的金額
            int price = 0;
            if (productText.Contains("$500")) price = 500;
            else if (productText.Contains("$250")) price = 250;
            else if (productText.Contains("$180")) price = 180;
            else if (productText.Contains("$300")) price = 300;
            else if (productText.Contains("$450")) price = 450;
            else if (productText.Contains("$200")) price = 200;
            else if (productText.Contains("$800")) price = 800;
            else if (productText.Contains("$1500")) price = 1500;
            else if (productText.Contains("$350")) price = 350;
            else if (productText.Contains("$420")) price = 420;
            else if (productText.Contains("$380")) price = 380;
            else if (productText.Contains("$150")) price = 150;
            else if (productText.Contains("$290")) price = 290;
            else if (productText.Contains("$120")) price = 120;
            else if (productText.Contains("$2800")) price = 3000;
            else if (productText.Contains("$3500")) price = 3500;
            else if (productText.Contains("$100")) price = 120;

            // 將抓到的整數價格存進我們的數字清單 cartPrices 中，方便最後算總分
            cartPrices.Add(price);
            // 每點一次商品，就用 foreach 迴圈重新加總，讓 Label 數字立刻變動！
            int currentSum = 0;
            foreach (int singlePrice in cartPrices)
            {
                currentSum = currentSum + singlePrice;
            }
            lblResult.Text = $"總金額： {currentSum} 元";

            // 重設選取狀態，方便下一次重複點選
            lstProducts.SelectedIndex = -1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 防錯檢查：如果下方購物車裡根本沒東西，算出來一定是 0 元，給予警告提示
            if (lstCart.Items.Count == 0)
            {
                MessageBox.Show("您的購物車目前空空如也，快去選購一些鸚鵡用品吧！", "提示");
                return;
            }

            // 因為前面點商品時已經即時算好錢了，這裡我們直接用迴圈取得總金額來顯示發票即可
            int finalSum = 0;
            foreach (int singlePrice in cartPrices)
            {
                finalSum = finalSum + singlePrice;
            }

            // 彈出精美的高級結帳發票視窗
            MessageBox.Show($"結帳成功！\r\n\r\n本次消費總計商品件數：{lstCart.Items.Count} 件\r\n應付總金額：{finalSum} 元\r\n感謝您為鳥寶的付出！", "結帳發票明細");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 清空下方購物車的所有顯示品項
            lstCart.Items.Clear();
            // 清空後台記錄的價格陣列
            cartPrices.Clear();
            // 將總金額標籤恢復成 0 元
            lblResult.Text = "總金額：0 元";

            MessageBox.Show("購物車已成功清空！您可以重新挑選商品囉。", "提示");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // 關閉當前的購物車視窗，程式會自動帶你回到主選單 (FrmMain) 
            this.Close();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
