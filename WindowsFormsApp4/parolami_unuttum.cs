using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp4
{
    public partial class parolami_unuttum : Form
    {

        MySqlConnection baglan;

        public parolami_unuttum()
        {
            InitializeComponent();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            //iptal butonuna basılınca form kapanır kullanıcı giriş formu açılır.

            this.Close();
            kullanici_girisi kg = new kullanici_girisi();
            kg.ShowDialog();
        }

        private void btn_sifreYolla_Click(object sender, EventArgs e)
        {
            // gerekli alanların doldurulması için iletilecek mesaj
            if (txt_mail.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanı Dodurunuz", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                string k_adi = txt_mail.Text;

                bool kayitlimi = false;

                //veritabanı bağlantısı gerekli veriler

                string _server = "localhost";
                string _dbname = "kullanici_girisi";
                string _user = "root";
                string _password = "Kuleli172@";

                string MySQLbaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

                using (baglan = new MySqlConnection(MySQLbaglanti))
                {
                    try
                    {
                        baglan.Open();

                    }

                    // bağlantı hatası mesajı
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bağlantı Yapılamadı... Nedeni: \n" + hata.ToString(), "Hata :" + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                baglan.Open();

                // veritabanındaki sistem için oluşturulan tablodaki verilere erişme

                MySqlCommand cmd = new MySqlCommand("SELECT*FROM kullanici_bilgileri", baglan);
                MySqlDataReader dr = cmd.ExecuteReader();

                string parola;
                
                while (dr.Read())
                {
                    // veritabanındaki mail adı ile sisteme girilen mail adının kontrolünün yapılması

                    if (k_adi == dr["e_mail"].ToString())
                    {
                        //eşleşme doğru ise parola değişkenine veritabanındaki parola atanması.

                        kayitlimi = true;
                       parola= dr["Parola"].ToString();
                        break;
                    }
                }

                //sisteme girilen e-mail adresi veritabanında kayıtlı ise

                if (kayitlimi == true)
                {

                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("tezkontrolsistemi@gmail.com","tezkontrol");
                    
                    // sistem için oluşturulmuş mail hesabından kullanıcının hesabına veritabanındaki parolası iletilecektir.

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("tezkontrolsistemi@gmail.com", "Tez Kontrol Sistemi Parola Hatırlatma Servisi");
                    mail.To.Add(k_adi);
                    mail.IsBodyHtml = true;
                    parola = dr["Parola"].ToString();
                    mail.Body = "Parolanız: "+ parola + " Lütfen Kimseyle Paylaşmayınız.";
                    mail.Subject = " Parola Hatırlatma ";
                    sc.Send(mail);


                    // mail işlemi bittikten sonra kullanıcıya mesaj iletilecektir. 

                    MessageBox.Show("Parolanız e-Mail Hesabınıza Gönderilmiştir. Lütfen Mail Hesabınızı Kontrol Ediniz","Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // formun kapatılıp kullanıcı girişi formunun açılması

                    this.Close();

                    kullanici_girisi kg = new kullanici_girisi();
                    kg.ShowDialog();

                }
                else MessageBox.Show("Girdiğiniz Maile Ait Kayıtlı Kullanıcı Bulunamadı! Lütfen Bilgilerinizi Kontrol Ediniz..", "Hatalı Giriş",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //veritabanı bağlantısının kapatılması

                baglan.Close();
            }
        }
    }
}
