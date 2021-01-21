using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class kullanici_girisi : Form
    {

      // veritabanı bağlantı değişkeninin oluşturulması.
      
        MySqlConnection baglan;

        public kullanici_girisi()
        {
            InitializeComponent();
        }

        // form1'de kullanılmak üzere oluşturulan değişken

        public static string isim;
        public static string soyisim;

        public void tKSNedirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // yardım menüsünde tks nedir butonuna tıklanması durumunda verilecek mesaj

            MessageBox.Show("Bu sistemin amacı;" +
           " son sınıf lisans öğrencilerinin yazmış olduğu bitirme tezlerini, önceden belirlenmiş tez yazım kurallarına göre kontrol etmektir.", "TKS Nedir?"
           , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void nasılKullanılırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // yardım menüsünde nasıl kullanılır butonuna tıklanması durumunda verilecek mesaj.

            MessageBox.Show("Sisteme üye olduktan sonra aşağıda istenen gereksinimleri doğru şekilde sisteme giriniz. " +
                "Ardından Tez Kontrol Sisteminin anasayfasına yönlendirileceksiniz. Kullanım koşulları TKS sayfasında detaylı olarak anlatılmıştır.",
                "Nasıl Kullanılır?", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
        public void nasılÜyeOlurumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // yardım menüsünde nasıl üye olurum butonuna tıklanması durumunda verilecek mesaj.

            MessageBox.Show("Sol alt kısımda verilen 'Üye Ol' butonuna tıklayarak açılan formda üye olabilirsiniz. " +
                "Üye olabilmeniz için geçerli bir e-Mail hesabınızın olması gereklidir. ", "Nasıl Üye Olurum?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void parolamıUnuttumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // yardım menüsünde parolamı unuttum butonuna tıklanması durumunda verilecek mesaj.

            MessageBox.Show("Alt Orta kısımda verilen 'Parolamı Unuttum' butonuna tıklayıp açılan sayfada e-Mail adresinizi girip, " +
                "mail hesabınaza gelen parolanızı kontrol edip, tekrardan kullanabilirsiniz.", "Parolamı Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void gMailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // iletişim menüsünde gmail butonuna tıklanması durumunda verilecek mesaj.

            MessageBox.Show("ahmetcekin2000@gmail.com", "E-Mail Adresimiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void instagramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // iletişim menüsünde instagram butonuna tıklanması durumunda verilecek mesaj.

            MessageBox.Show("https://www.instagram.com/_ahmetcekin", "İnstagram Hesabımız", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lisansMetniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // telif hakları menüsünde lisans metni butonuna tıklanması durumunda verilecek mesaj.

            MessageBox.Show("Bu uygulamanın telif hakkı saklıdır. İzinsiz kullanılamaz.", "Telif Hakkı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void geliştiriciProfiliToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // hakkında menüsünde geliştirici profili butonuna tıklanması durumunda verilecek mesaj.

            MessageBox.Show("Ahmet ÇEKİN 2000 yılında Malatya'da doğmuştur. İlk ve Orta Öğrenimini Malatya'da tamamladıktan sonra, " +
                "İstanbul Kuleli Askeri Lisesi'ne başlamıştır. Şu anda Fırat Üniversitesi Teknoloji Fakültesi Yazılım Mühendisliği " +
                "2. sınıf öğrencisidir.", "Geliştirici Profili", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_uyeol_Click(object sender, EventArgs e)
        {

            // üye ol butonuna tıklanması durumunda geçerli formun gizlenmesi ve üye formunun açılması

            üye_formu üf = new üye_formu();
            üf.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            // giriş butonuna tıklanması durumundaki işlemler.

            if(txt_email.Text == "" && txt_parola.Text == "")
            {
                // e-mail veya parola boş bırakılırsa sistemin vereceği uyarı mesajı

                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                string k_adi = txt_email.Text;
                string prl = txt_parola.Text;

                bool kayitlimi = false;

                // veritabanı bilgileri

                string _server = "localhost";
                string _dbname = "kullanici_girisi";
                string _user = "root";
                string _password = "Kuleli172@";

                string MySQLbaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

                // veritabanı bağlantısı

                using (baglan = new MySqlConnection(MySQLbaglanti))
                {
                    try
                    {
                        baglan.Open();

                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bağlantı Yapılamadı... Nedeni: \n" + hata.ToString(), "Hata :" + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                baglan.Open();

                // veritabanı komut ve tarama nesnelerinin oluşturulması
                // ilgili veritabanı komutunun cmd değişkenine atanması

                MySqlCommand cmd = new MySqlCommand("SELECT*FROM kullanici_bilgileri", baglan);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // sistemde kullanılan kullanıcı adı ve parola eşleşmesinin yapılması

                    if (k_adi == dr["e_mail"].ToString() && prl == dr["Parola"].ToString())
                    {
                        // form1 için göderilecek isi ve soyisim değerlerinin atanması

                        kullanici_girisi.isim = dr["Adı"].ToString();
                        kullanici_girisi.soyisim = dr["Soyadı"].ToString();

                        // sistem içerisindeki eşleşme sonucu kayıtlimi ifadesinin değerrinin true yapılması ve döngünden çıkılması

                        kayitlimi = true;
                        break;
                        
                    }
                }
                if (kayitlimi == true)
                {
                    //eşeleşme durumunda kullanıcıya verilecek mesaj ve geçerli formun kapatılıp form1'in açılması

                    MessageBox.Show("Giriş Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();

                }

                // veritabanında verilen kullanıcı adı veya parola hatalıysa kullanıcıya verilecek olan hata mesajı.

                else MessageBox.Show("Hatalı Giriş Yaptınız! Lütfen Bilgilerinizi Kontrol Ediniz..", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                // veritabanı bağlantısının kapatılması

               baglan.Close();
            }
            
        }

        private void btn_prlunuttum_Click(object sender, EventArgs e)
        {
            // parolamı unuttum butonuna tıklanması durumunda geçerli formun gizlenmesi ve parolamı unuttum formunun açılması.

            this.Hide();
            parolami_unuttum pu = new parolami_unuttum();
            pu.ShowDialog();
        }
    }
}
