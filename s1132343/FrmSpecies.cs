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
    public partial class FrmSpecies : Form
    {
        public FrmSpecies()
        {
            InitializeComponent();
        }

        private void lstSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 安全檢查：如果什麼都沒選（索引值為 -1），就立刻結束執行，防範程式閃退
            if (lstSpecies.SelectedIndex == -1) return;

            // 取得目前被選取的鸚鵡名稱字串
            string selectedParrot = lstSpecies.SelectedItem.ToString();

            // 利用一連串簡單的 if-else 條件判斷，動態切換 PictureBox 的圖片與 TextBox 的詳細介紹
            if (selectedParrot == "玄鳳鸚鵡")
            {
                picParrot.Image = Properties.Resources.玄鳳鸚鵡;
                txtIntro.Text = "【玄鳳鸚鵡 (Cockatiel)】\r\n\r\n" +
                               "★ 外觀特色：頭上有標誌性的黃色高聳冠羽，臉頰兩側有著像塗了腮紅般的圓形紅斑，非常呆萌可愛。\r\n" +
                               "★ 體型壽命：屬於中小型鸚鵡，體長約 30-33 公分，平均壽命大約 15 - 20 年。\r\n" +
                               "★ 習性特色：生性膽小、溫和且極度熱愛撒嬌。牠們非常擅長吹口哨，只要耐心教導，就能學會吹出簡單的樂曲（例如龍貓主題曲或垃圾車音樂），不過牠們的語言模仿與說話能力相對比較普通。";
            }
            else if (selectedParrot == "和尚鸚鵡")
            {
                picParrot.Image = Properties.Resources.和尚鸚鵡;
                txtIntro.Text = "【和尚鸚鵡 (Monk Parakeet)】\r\n\r\n" +
                               "★ 外觀特色：常見的有綠色、藍色、黃色等。因為牠們胸前至腹部的羽毛顏色淡淡的，看起來很像和尚穿的袈裟而得名。\r\n" +
                               "★ 體型壽命：屬於中型鸚鵡，體長約 28-30 公分，平均壽命大約 15 - 25 年。\r\n" +
                               "★ 習性特色：智商非常高，是中小型鸚鵡中的「說話大師」，極易學會人類語言！不過牠們的個性比較剛烈，佔有慾強，容易出現強烈的「護籠」行為（討厭別人碰牠的籠子），且叫聲相對比較洪亮大聲。";
            }
            else if (selectedParrot == "虎皮鸚鵡")
            {
                picParrot.Image = Properties.Resources.虎皮鸚鵡;
                txtIntro.Text = "【虎皮鸚鵡 (Budgerigar)】\r\n\r\n" +
                               "★ 外觀特色：頭部與背部羽毛有著像老虎皮一樣的細密黑色條紋，人工繁育品種非常多，顏色五彩斑斕。\r\n" +
                               "★ 體型壽命：屬於小型鸚鵡，體長約 15-20 公分，平均壽命大約 7 - 12 年。\r\n" +
                               "★ 習性特色：活潑好動、好奇心極強，是非常適合初學者飼養的入門鳥種。牠們體型小、吃得少、排泄物也少。雖然平時喜歡碎碎念地發出聲音，但整體音量不算大，公的虎皮鸚鵡其實也擁有很不錯的說話潛力。";
            }
            else if (selectedParrot == "小太陽鸚鵡")
            {
                picParrot.Image = Properties.Resources.小太陽鸚鵡;
                txtIntro.Text = "【小太陽鸚鵡 (Green-cheeked Conure)】\r\n\r\n" +
                               "★ 外觀特色：屬於錐尾鸚鵡的一種，胸口與肚子上分布著像太陽般溫暖亮眼的紅黃色羽毛，眼睛周圍有白色的眼圈。\r\n" +
                               "★ 體型壽命：屬於中小型鸚鵡，體長約 25 公分，平均壽命大約 10 - 15 年。\r\n" +
                               "★ 習性特色：是鳥界出了名的「黏人精」與「跟屁蟲」，超級喜歡躺在主人的手心裡撒嬌（俗稱翻滾）。雖然牠們的語言天賦較差，叫聲略顯沙啞，但牠們擁有非常豐富的肢體動作與調皮個性，深受飼主喜愛。";
            }
            else if (selectedParrot == "金剛鸚鵡")
            {
                picParrot.Image = Properties.Resources.金剛鸚鵡;
                txtIntro.Text = "【金剛鸚鵡 (Macaw)】\r\n\r\n" +
                               "★ 外觀特色：體型巨大，羽毛色彩極其艷麗（如紅金剛、藍金剛），擁有一對巨大、強壯且呈鉤狀的黑色鳥喙。\r\n" +
                               "★ 體型壽命：屬於大型鸚鵡，體長可達 80-100 公分，平均壽命極長，可達 50 - 80 年，甚至更長。\r\n" +
                               "★ 習性特色：智商非常卓越，相當於 3 至 5 歲的人類小孩。牠們情感細膩，需要飼主大量的陪伴與互動，否則容易焦慮拔毛。牠們的咬合力極其驚人，啃咬破壞力強，且叫聲極具穿透力，飼養需要龐大的空間與心理準備。";
            }
            else if (selectedParrot == "巴丹鸚鵡")
            {
                picParrot.Image = Properties.Resources.巴丹鸚鵡;
                txtIntro.Text = "【巴丹鸚鵡 (Cockatoo)】\r\n\r\n" +
                               "★ 外觀特色：多為純白、桃紅或黑色。頭頂上有一個非常巨大、顯眼的扇形大冠羽，興奮或警戒時會像扇子一樣展開。\r\n" +
                               "★ 體型壽命：屬於中大型鸚鵡，體長約 30-60 公分，平均壽命大約 40 - 60 年。\r\n" +
                               "★ 習性特色：被稱為鳥界的「靈魂舞者」與「搞笑大師」，非常喜歡隨著音樂節奏搖頭晃腦或跳舞。牠們極度依賴主人，黏人程度爆表，如果被冷落會發出如同尖叫般巨大的噪音。另外，牠們身上會分泌大量的白色羽粉，呼吸道敏感者需多加注意。";
            }
            else if (selectedParrot == "灰鸚鵡")
            {
                picParrot.Image = Properties.Resources.灰鸚鵡;
                txtIntro.Text = "【非洲灰鸚鵡 (African Grey Parrot)】\r\n\r\n" +
                               "★ 外觀特色：全身覆蓋著優雅的銀灰色羽毛，眼睛周圍有白色裸皮，最亮眼的是牠們擁有一條鮮艷如火的純紅色短尾巴。\r\n" +
                               "★ 體型壽命：屬於中大型鸚鵡，體長約 33-40 公分，平均壽命大約 40 - 50 年。\r\n" +
                               "★ 習性特色：被公認為鳥界「智商最高」的鸚鵡，科學研究證實其智力可達 5 歲人類小孩！語言模仿能力超級驚人，能完美模仿各種環境聲音與人聲，甚至能理解詞彙的意思。性格內向、敏感且多疑，非常注重規律生活，若環境變動大容易感到焦慮。";
            }
            else if (selectedParrot == "凱克鸚鵡")
            {
                picParrot.Image = Properties.Resources.凱克鸚鵡;
                txtIntro.Text = "【凱克鸚鵡 (Caique)】\r\n\r\n" +
                               "★ 外觀特色：常見的有黑頭凱克與金頭凱克。頭部顏色分明，肚子為純白色，翅膀為亮綠色，看起來就像穿了一件精緻的小西裝。\r\n" +
                               "★ 體型壽命：屬於中型鸚鵡，體長約 23-25 公分，平均壽命大約 25 - 30 年。\r\n" +
                               "★ 習性特色：有鳥界「過動兒」與「小跳豆」之稱！精力極度充沛，最著名的招牌動作是像兔子一樣在地上「雙腳向前跳躍」。牠們極度愛玩玩具，喜歡翻滾、摔跤，性格像小狗一樣好奇大膽，會帶給飼主無窮的歡樂，但需要準備非常多的玩具讓牠消耗體力。";
            }
            else if (selectedParrot == "愛情鳥")
            {
                picParrot.Image = Properties.Resources.愛情鳥鸚鵡;
                txtIntro.Text = "【愛情鳥 / 牡丹 / 面罩鸚鵡 (Lovebird)】\r\n\r\n" +
                               "★ 外觀特色：體型嬌小矮胖，尾巴很短，臉部與身體的顏色對比非常鮮明，眼神看起來非常有神靈動。\r\n" +
                               "★ 體型壽命：屬於小型鸚鵡，體長約 13-17 公分，平均壽命大約 10 - 15 年。\r\n" +
                               "★ 習性特色：得名於牠們對伴侶極其深情，經常兩兩依偎在一起互理羽毛。不過牠們的領域性與攻擊性非常強，俗稱「小辣椒」，如果跟其他種類的鳥養在一起容易發生打架。牠們雖然不太會說話，但叫聲清脆嘹亮。";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // 關閉當前的視窗，程式會自動回到主選單
            this.Close();
        }

        private void FrmSpecies_Load(object sender, EventArgs e)
        {
            //多按到的
        }

        private void picParrot_Click(object sender, EventArgs e)
        {

        }
    }
}
