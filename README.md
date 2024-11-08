# 📂 Folder Browser Dialog Aracı
- **Kullanım**: Dosya giriş-çıkış işlemlerinde konum seçmek için kullanılır. Sadece klasörleri ve dizinleri gösterir, dosya türleri gösterilmez.
- **Örnek**:
  ```csharp
  folderBrowserDialog1.ShowDialog(); // Butona tıklanınca Folder Browser'ın çalışmasını sağlıyoruz.
  label1.Text = folderBrowserDialog1.SelectedPath; // Seçilen yol (SelectedPath) Label'a yazdırılır.

# 📁 Open File Dialog Aracı
- **Kullanım**: Open File Dialog, Folder Browser aracından farklı olarak sadece klasörleri değil, dosyaları da görüntüler. Bu araç, kullanıcıya dosya seçme işlemlerinde yardımcı olur.
- **Filtreleme**: Dosya türlerini filtreleyerek yalnızca istenen türde dosyaların gösterilmesi sağlanabilir.
- **Örnek**:
  ```csharp
  openFileDialog1.ShowDialog(); // Dosya seçim penceresini açar.
  label1.Text = openFileDialog1.FileName; // Seçilen dosyanın adı ve yolunu Label'a yazdırır.

# 🛠 Tool
- **Tool**: Araç demek.
- **Toolbox**: Araç kutusu.

# ⚙️ Properties
- **Text**: Label aracının görünen metni.
- **BackColor**: Arka plan rengi.
- **ForeColor**: Yazı rengi.
- **DropDownStyle**:
  - **DropDownList**: Combobox için dışarıdan veri girişini engeller, sadece seçim yapılabilir.
  - **Simple**: Listesiz kullanım sunar, pek tercih edilmez.
- **Enabled**: Bir araca dışarıdan müdahaleyi veya veri girişini kapatıp açmamıza yarar.
- **StartPositions**: Uygulamanın açılış pozisyonunu belirler.
  - **CenterScreen**: Formun ekranın ortasında açılmasını sağlar.
  - **CenterParent**: Formu, ebeveyn penceresinin merkezinde açar.
  - **WindowsDefaultLocation**: İşletim sistemi tarafından belirlenen varsayılan konumda açar.
  - **WindowsDefaultBounds**: Varsayılan konumda ve boyutlarla açar.
- **Opacity**: Şeffaflık ayarı.

# 🏷️ Label Aracı
- Etiket görevi görür; açıklamalar için kullanılır.
- **Text**: Label aracının görünen metni.

# 🔘 Button Aracı
- Olayları gerçekleştirmek için kullanılan tetikleyici araçtır.
- **BackColor**: Arka plan rengi.
- **ForeColor**: Yazı rengi.

# 📝 TextBox Aracı
- Kullanıcıdan veri girişi yapmak için kullanılır.

# 📋 ComboBox Aracı
- Çoklu seçim kutusu olarak kullanılır; istenilen değerlerden birini seçmek için.
- **DropDownStyle**:
  - **DropDownList**: Dışarıdan veri girişini engeller, sadece seçim yapılabilir.
  - **Simple**: Listesiz kullanım sunar, pek tercih edilmez.

# 📜 ListBox Aracı
- Verilerin listelenmesi için kullanılır; ComboBox'a benzer.
- Veriler `items.Add` komutuyla ListBox'a eklenir.
  - Örnek: `listBox1.Items.Add("PosteSQL");`

# 🔒 MaskedTextBox Aracı
- Maskeli metin kutusu, telefon numarası veya e-posta gibi özel alanlar için kullanılır.

  **Özel Tanımlama**:
  - **A**: Alfabetik veya sayısal karakter kabul eder.
  - **L**: Yalnızca alfabetik karakter kabul eder.
  - **0**: Yalnızca sayısal karakter kabul eder.
  - **C**: Herhangi bir karakter kabul eder (boş bırakılabilir).
  - **\\**: Takip eden karakteri sabit metin olarak kabul eder (örneğin `\M` harfi 'M' olarak görünür).

  **Örnek**: `\T\C00000000000` - TC Kimlik numarası için maske tanımlaması.

# 🖼️ PictureBox Aracı
- Formda resim kutusu olarak kullanılır.
- **Choose Image**: Resim seç.
  - **Resource Context**: Yerel kaynaktan resim seç.
  - **Import**: Resmi dahil et.
  - **Project Resource File**: Projedeki resmi seç.
- **Size Mode**: Resim boyutlandırma modu.
  - **StretchImage**: Resmi PictureBox'a göre tam kaplar.
  - **Dock in Parent Container**: Formun tamamını kaplar.

# 🗃️ GroupBox Aracı
- Araçları gruplandırmak için kullanılır; ilişkili bileşenleri bir arada tutar.

# 💬 MessageBox Aracı
- Kullanıcıya mesaj göstermek için bir dialog penceresi açar.
  - **Parametreler**: Mesaj, Başlık, Buton Türü, İkon.

# 📂 MenuStrip Aracı
- Masaüstü programlarda üst menü oluşturmak için kullanılır; menüler alt veya sağ tarafa doğru genişleyebilir.

# 🌐 Web Browser Aracı
- Form üzerinden web sayfalarına erişim sağlar.
  - **Varsayılan**: Internet Explorer altyapısını kullanır.

# 🖱️ Context MenuStrip Aracı
- Formda sağ tuş menüsü oluşturur; birden fazla Context MenuStrip yapılabilir ve ayarlanabilir.

# ⏰ Timer Aracı
- Zamanlayıcı olarak kullanılan araç; belirli periyotlarda otomatik işlemler için.
  - **Interval**: Milisaniye cinsinden tetiklenme aralığı (örneğin, 1000 ms = 1 saniye).
  - **Enabled**: Timer'ın aktif olup olmadığını belirler.
  - **Tick**: Timer tetiklendiğinde çalışacak işlemler.

# 📊 Chart Aracı
- Grafik üzerinde veri gösterimi için kullanılır; özellikle veritabanı işlemlerinde.
  - **Series (Seriler)**: Veriler x ve y koordinatlarında gösterilir.

### 📈 Chart Areas (Grafik Alanları)
- **Name**: Benzersiz bir ad gerektirir.
- **AxisX**, **AxisY**: X ve Y ekseni özellikleri; arka plan rengi, çizgi rengi gibi detaylar.
- **BackColor** ve **BorderColor**: Arka plan ve kenarlık rengi ayarları.

### 🧩 Series (Seriler)
- **Name**: Benzersiz bir ad.
- **ChartType**: Grafik türü (örneğin, Line, Bar, Pie).
- **Color** ve **BorderWidth**: Seri rengi ve çizgi kalınlığı.
- **IsValueShownAsLabel**: Verinin etiket olarak gösterilip gösterilmeyeceğini belirler.
- **MarkerStyle**: Veri noktalarının stili (örneğin, Circle, Square).

### 📑 Legends (Açıklamalar)
- **Name**: Benzersiz ad.
- **Docking**: Yerleşim konumu (örneğin, Top, Bottom).
- **BackColor** ve **Font**: Arka plan rengi ve yazı tipi.

### 🖋️ Titles (Başlıklar)
- **Text**: Başlık metni.
- **Font**: Yazı tipi ve boyutu.
- **Alignment**: Başlık hizalaması.
- **ForeColor**: Yazı rengi.

### 🛠️ Chart Properties (Genel Özellikler)
- **BackColor** ve **BorderlineColor**: Arka plan ve kenarlık rengi.
- **AntiAliasing**: Grafik kalitesini artırır.
- **Palette**: Renk paleti (Bright, EarthTones gibi).

### 📏 Axes (Eksenler)
- **Title**: Eksen başlığı.
- **Interval**: Eksen aralığı.
- **LabelStyle**: Eksen üzerindeki etiketlerin stili.
- **MajorGrid** ve **MinorGrid**: Çizgilerin görünürlüğü ve stili.

### 📌 Chart Events (Olaylar)
- **Click**: Grafik üzerine tıklama.
- **MouseMove**: Fare hareketini izleme.
- **Customize**: Grafik özelleştirme olayı.
- **PostPaint ve PrePaint**: Çizim öncesi ve sonrası özel işlemler.

# 📶 ProgressBar Aracı
- Sayısal değerin bir ilerleme çubuğu üzerinde gösterimi; minimum ve maksimum değerleri ayarlanabilir.

# ✅ CheckBox Aracı
- Kontrol kutusu; çoklu seçimlerde kullanılır.
- İki durumlu: True / False.

# 🔘 RadioButton Aracı
- Çoklu seçimde sadece bir seçenek belirlenir; aynı anda yalnızca bir seçenek işaretlenebilir.
