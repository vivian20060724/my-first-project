# my-first-project
鸚鵡飼育具高度專業性，新手飼主常面臨品種辨識困難、不解啃咬天性、用品採購預算難估，以及缺乏數位化健康登記管道等痛點。因此我製作了此系統，希望能降低飼育門檻，並透過數位化工具協助新/舊飼主養育鳥寶們。

# 主頁

按鍵與選單功能：頂部 MenuStrip 提供網頁式導覽（百科、習性、購物、登記、離開）。畫面上標題文字漸進呼吸特效。

核心程式碼邏輯：利用 Timer 元件的 Tick 事件，動態調整 Label 的 Font 尺寸與顏色。

<img width="700" height="221" alt="image" src="https://github.com/user-attachments/assets/9442cc43-118c-43e5-9f92-bc147f5281a6" />

# 鸚鵡種類大百科

按鍵與選單功能：點選左側 ListBox 中的 9 種鸚鵡品項，中央 PictureBox 會同步跑出對應鸚鵡的照片，右側TextBox 則動態生成該品種的詳細習性介紹。

核心程式碼邏輯：在 ListBox 的 SelectedIndexChanged 事件中，撰寫多層 if-else 判斷式，根據 SelectedItem 的字串內容變更對應的圖片與文字。

<img width="758" height="457" alt="image" src="https://github.com/user-attachments/assets/843bdfe8-3625-457b-9c78-e226e5707222" />

# 鸚鵡習性測驗

按鍵與選單功能：透過 TabControl 分頁展示四大天性。下方 CheckedListBox 包含 8 題心理素質測驗，點擊「送出」後，會跳出不同評語的訊息視窗，來自我檢測自己是不是真的適合養鸚鵡。

核心程式碼邏輯：使用 for 迴圈搭配 CheckedListBox.GetItemChecked(i) 累加勾選總數，再以 if-else 進行分數級別評定。

<img width="707" height="585" alt="image" src="https://github.com/user-attachments/assets/1b520260-44e9-4a7b-a089-e43e89c811fe" />

# 購物計算器

按鍵與選單功能：左側選擇 7 大分類，中間動態用 if-else 注入商品品項；點擊右邊跑出的商品即自動加入下方購物車並「即時累加總金額」；點擊清空按鈕立即歸零，點擊結帳則跑出發票明細。

核心程式碼邏輯：使用 List<int> 動態陣列在後台儲存每項商品的金額，當商品被點選時，使用 foreach 迴圈即時更新總金額 Label。

<img width="803" height="462" alt="image" src="https://github.com/user-attachments/assets/5238235d-564b-43b0-a1e0-ea173dcf3fd7" />

# 鳥寶資料登記

按鍵與選單功能：收集鳥寶與家長資料。填寫完畢點擊「確認送出」會經由防錯機制驗證，成功則跑出登記建檔成功。

核心程式碼邏輯：利用 .Trim() == "" 進行空白欄位防錯驗證；讀取 RadioButton.Checked 與 CheckBox.Checked 狀態，最終將 TextBox、ComboBox 與 NumericUpDown 的資料進行多字串串接輸出。

<img width="527" height="437" alt="image" src="https://github.com/user-attachments/assets/e80e99f3-e001-4b81-bcf4-fd5162fe5f61" />

# 開發技術與環境
*開發語言**：C#

*使用者介面**：Windows Forms (.NET)

*開發工具**：Visual Studio
