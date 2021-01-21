using System;
using System.Windows.Forms;

using Microsoft.Office.Interop.Word;
using System.IO;
using System.Drawing;
using System.Text;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btn_dosyasec_Click(object sender, EventArgs e)
        {
            // kullanıcının sistem için bilgisayarında seçeceği tez dosyasının bulunması ve sisteme iletilmesi
            
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Word Dosyası |*.docx";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Word Dosyası Seçiniz...";

            if (file.ShowDialog() == DialogResult.OK)
            {
                // Sistem içerisinde kontrol edilen dosya bilgisini ekranda yazdırmak için atama ifadesi 

                string dosyayolu = file.FileName;
                string dosya_adi = file.SafeFileName;

                {
                    // sistemin dosya kontrolü sırasındaki mesajı

                    label1.Text = dosya_adi + " Dosyası Kontrol Ediliyor. Lütfen Bekleyiniz...";

                    richTextBox1.Clear();

                    // kontrol edilecek olan word dosyasının taranması için Microsoft Office Word nesnesinin oluşturulması

                    Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();

                    object nullobject = System.Reflection.Missing.Value;

                    // seçilen word dosyasının açılması

                    Microsoft.Office.Interop.Word.Document docs = wordObject.Documents.Open(dosyayolu);

                    docs.ActiveWindow.Selection.WholeStory();
                    docs.ActiveWindow.Selection.Copy();
                    IDataObject data = Clipboard.GetDataObject();

                    //string tumu = data.GetData(DataFormats.Text).ToString(); tüm word sayfalarını getirir.

                    //tez dosyasındaki hataların konumunu belirtmek için değişken belirleme.

                    string satir = "";
                    int i = 1;

                    Document ddd = new Document();
                    ddd = docs;

                    // oluşturulan Document nesnesinin tüm satırların taranması 

                    foreach (Microsoft.Office.Interop.Word.Paragraph objParagraph in docs.Paragraphs)
                    {
                        // font özelliklerinin kontrolü için oluşturulan satır konumun Font özelliğine atanması.

                       

                        Microsoft.Office.Interop.Word.Font s = docs.Paragraphs[i].Range.Font;
                        
       

                        if (docs.Paragraphs[i].Range.Text == "ÖNSÖZ")
                        {
                            richTextBox1.Text += "\n ÖNSÖZ MEVCUTTUR " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "İÇİNDEKİLER")
                        {
                            richTextBox1.Text += "\n İÇİNDEKİLER LİSTESİ MEVCUTTUR" + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "ÖZET")
                        {
                            richTextBox1.Text += "\n ÖZET METNİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "ABSTRACT")
                        {
                            richTextBox1.Text += "\n İNGİLİZCE ÖZET METNİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "ŞEKİLLER LİSTESİ")
                        {
                            richTextBox1.Text += "\n ŞEKİLLER LİSTESİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "TABLOLAR LİSTESİ")
                        {
                            richTextBox1.Text += "\n TABLOLAR LİSTESİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "EKLER LİSTESİ")
                        {
                            richTextBox1.Text += "\n EKLER LİSTESİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "SİMGELER VE KISALTMALAR")
                        {
                            richTextBox1.Text += "\n SİMGELER VE KISALTMLAR MEVCUTTUR." + i;
                        }

                        if (s.Size == 12F)
                        {

                            // yazı fontunun 12 olması durumunda kontrol edilecek ifadeler.

                            if (s.Position.ToString() != "wdVerticalAlignmentLeft")
                            {
                                //pozisyon kontrolü
                                richTextBox1.Text += "\n ara başlık sola yaslı değil satır :" + i;
                            }
                            if (s.ColorIndex.ToString() != "wdBlack")
                            {
                                //yazı rengi kontrolü
                                richTextBox1.Text += "\n yazı rengi yanlış satır:" + i;
                            }
                            if (s.Name.ToString() != "Times New Roman")
                            {
                                // yazı stili kontrolü
                                richTextBox1.Text += "\n yazı stili yanlış satır:" + i;
                            }
                        }
                        else
                        if (s.Size == 16F)
                        {
                            // yazı fontunun 16 olması durumunda kontrol edilecek ifadeler.

                            if (s.Position.ToString() != "WdVerticalAlignmentCenter")
                            {
                                // pozisyon kontrolü
                                richTextBox1.Text += "\n ana başlık iki yana yaslı değil satır:  " + i;
                            }
                            if (s.ColorIndex.ToString() != "wdBlack")
                            {
                                //yazı rengi kontrolü
                                richTextBox1.Text += "\n yazı rengi yanlış satır:" + i;
                            }
                            if (s.Name.ToString() != "Times New Roman")
                            {
                                // yazı stili kontrolü
                                richTextBox1.Text += "\n yazı stili yanlış satır:" + i;
                            }

                        }
                        else
                        if (s.Size == 11F)
                        {
                            // yazı fontunun 11 olması durumunda kontrol edilecek ifadeler.

                            if (s.Position.ToString() != "WdVerticalAlignmentCenter")
                            {
                                // pozisyon kontrolü 
                                richTextBox1.Text += "\n ana başlık iki yana yaslı değil satır:  " + i;
                            }
                            if (s.ColorIndex.ToString() != "wdBlack")
                            {
                                // yazı rengi kontrolü
                                richTextBox1.Text += "\n yazı rengi yanlış satır:" + i;
                            }
                            if (s.Name.ToString() != "Times New Roman")
                            {
                                // yazı stili kontrolü
                                richTextBox1.Text += "\n yazı stili yanlış satır:" + i;
                            }

                        }
                        // kılavuzda belirtilen tüm yazı fontlarının kontrolü yapıldı

                        else
                        {
                            // eğer kılavuzda belirtilen yazı fontu dışında bir font varsa kontolü bu blokta yapılacaktır.
                            
                            richTextBox1.Text += "\n yazı boyutu 11 punto değil satır:" + i;

                            if (s.Name.ToString() != "Times New Roman")
                            {
                                richTextBox1.Text += "\n yazı stili yanlış satır:" + i;
                            }
                            if (s.ColorIndex.ToString() != "wdBlack")
                            {
                                richTextBox1.Text += "\n yazı rengi yanlış satır:" + i;
                            }
                        }

                        

                        // satır konumunun arttırılıp sonraki satır konumun kontrolünün yapılması

                            i++;
                        }

                        i = 1;


                        // üst boşluk kontrolü
                        if (ddd.PageSetup.TopMargin.ToString() != "85,05")
                        {
                            richTextBox1.Text += "\n üst boşluk yanlış:";
                        }

                        //sol boşluk kontrolü
                        if (ddd.PageSetup.LeftMargin.ToString() != "92,15")
                        {
                            richTextBox1.Text += "\n sol boşluk yanlış:";
                        }

                        //sağ boşluk kontrolü
                        if (ddd.PageSetup.RightMargin.ToString() != "70,9")
                        {
                            richTextBox1.Text += "\n sağ boşluk yanlış:";
                        }

                        // alt boşluk kontrolü
                        if (ddd.PageSetup.BottomMargin.ToString() != "70,9")
                        {
                            richTextBox1.Text += "\n alt boşluk yanlış:";
                        }

                        // paragrafın düzen kontrolü
                        if (ddd.Paragraphs.Alignment != WdParagraphAlignment.wdAlignParagraphCenter)
                        {
                            richTextBox1.Text += "\n iki yana yaslı değil";

                        // kontrol işleminden sonra kullanıcın sisteme ilettiği dosyanın kontrolünün tamamlandığını göstermek için metin ataması.
                            label1.Text = dosya_adi + " Dosyası Kontrol Edildi. Ayrıntılar Aşağıdaki Kısımdadır.";
                        }

                        // tarama işleminin bittiğini kullanıcıya ileten kısım
                        MessageBox.Show("Tarama İşlemi Başarılı Bir Şekilde Tamamlandı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        docs.Close(ref nullobject, ref nullobject, ref nullobject);


                    git:
                        return;
                    
                }
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            // form üzerinde bulunan çıkış butonu ile bu form gizlenip sistemin ana sayfası olan kullanıcı giriş formu açılacaktır.
            this.Hide();
            kullanici_girisi kg = new kullanici_girisi();
            kg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // kullanıcının sisteme girdiği  mail hesabına ait ad soyad bilgisi kullanıcı_girişi formundan çekilip veritabanı kontrolü ile  sistemde hoş geldiniz mesajı iletimi.
            
            lbl_giris.Text = "Sayın " +kullanici_girisi.isim + " " +kullanici_girisi.soyisim + " Hoş Geldiniz.";
        }

        private void nasılKullanılırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // yardım menüsünden nasıl kullanılır butonun mesajı

            MessageBox.Show("Kontrol etmek istediğiniz tez dosyasının bilgisayarınızda kayıtlı olduğuna dikkat ediniz. " +
                "Sağ tarafta bulunan 'Dosya Seç' butonuna tıklayıp açılan ekranda bilgisayarınızdaki Word türündeki dosyalar görünecektir. " +
                "Kontrol etmek istediğiniz tez dosyasını seçiniz. Bu adımdan sonra sistem tezinizi kontrol edecektir. " +
                "Dosyanızın boyutuna göre bekleme süreniz değişebilir. Eksik ve hatalı kurallar aşağıdaki mavi alanda gösterilecektir. " +
                "Tarama işleminden sona uyarı mesajı verilecektir. Uyarı mesajı almadan sistemden ayrılmamanızı tavsiye ederiz. ", "Nasıl Kullanırım?",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dosyaTürüNeOlmalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // yardım menüsünden dosya türü ne olmalıdır butonun mesajı

            MessageBox.Show("Dosya Türünüz Word yani .docx uzantılı olmalıdır. Aksi takdirde sistem içerisine dosya yükleme işlemini gerçekleştiremezsiniz. " 
                ,"Dosya Türü", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void sistemGecikmesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // yardım menüsünden sistem gecikmesi butonun mesajı

            MessageBox.Show("Seçeceğiniz tez dosyasının boyutuna göre Sistemimiz 20-60 saniye arasında gecikmeye uğrayabilir. Bekleme süreniz için Özür Dileriz.", "Bekleme Süresi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void telifHakkıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // lisans menüsünün telif hakkı butonunun mesajı

            MessageBox.Show("Sistemin tüm hakları gizlidir ve Kuleli Yazılım şirketine aittir. İzinsiz kullanımı yasaktır.", "Telif Hakkı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void piloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hakkında menüsünün pilot uygulama butonunun mesajıdır.

            MessageBox.Show("Bu sistem öncelikli olarak Fırat Üniversitesi bünyesinde gerçekleştirilmiştir.", "Pilot Uygulama", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void güvenlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hakkında menüsünün güvenlik butonunun mesajıdır.

            MessageBox.Show("Tez Kontrol Sistemi üyelerin kişisel verilerini korumakla yükümlüdür. Kişisel verileriniz kayıt altında ve üçüncü " +
                "bir kullanıcılar tarafından bile erişilemez durumdadır", "Kişisel Veri Güvenliği", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
