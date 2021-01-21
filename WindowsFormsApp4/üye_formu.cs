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
namespace WindowsFormsApp4
{
    public partial class üye_formu : Form
    {
        MySqlCommand komut;
        MySqlConnection baglan;

        public üye_formu()
        {
            InitializeComponent();

           
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            // iptal butonuna tıklanınca geçerli formun kapatılması ve kullanıcı giriş formunun açılması

            this.Close();
            kullanici_girisi kg = new kullanici_girisi();
            kg.Show();
        }

        private void btn_üyeol_Click(object sender, EventArgs e)
        {
            // üyelik işlemleri

            string a = txt_email.Text;
            bool kontrol = false;

            if (txt_ad.Text != "" && txt_email.Text != "" && txt_soyadı.Text != "" && txt_parola.Text != "")
            {
                // gerekli alanların tamamnın doldurulmasının kontrolü

                kontrol = true;
            }
            else
            {
                //eksik alan varsa uyarı mesajının verilmesi

                MessageBox.Show( "Alanların Tamamı Doldurulmalıdır. Aksi Takdirde Üyelik İşlemi Gerçekleştirilemez!",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            // e-mail formatının '@' ifadesinin kontrolü

            if (a.Contains("@") == true && kontrol==true)
                {
                // mail adresi kontrolünden sonra veritabanı bağlantısının gerçekleştrilmesi

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

                    // sorgu değişkenine ad,soyad,e-mail,parola, değişkenlerinin veritabanındaki ekleme komutunun yazılması ve atanması.

                    string sorgu = "INSERT INTO kullanici_bilgileri(Adı,Soyadı,e_mail,Parola) VALUES" +
                       " (@Adı,@Soyadı,@e_mail,@Parola)";
                    komut = new MySqlCommand(sorgu, baglan);

                // veritabanındaki ilgili tabloya üye verilrinin eklenmesi
                
                    komut.Parameters.AddWithValue("@Adı", txt_ad.Text);
                    komut.Parameters.AddWithValue("@Soyadı", txt_soyadı.Text);
                    komut.Parameters.AddWithValue("@e_mail", txt_email.Text);
                    komut.Parameters.AddWithValue("@Parola", txt_parola.Text);

                    baglan.Open();
                    komut.ExecuteNonQuery();
                    baglan.Close();

                // işlemin başarılı şekilde tamamlanması ile verilen mesaj kısmı

                    MessageBox.Show("Üyelik işlemleriniz Başarılı Bir Şekilde Gerçekleştirilmiştir. Teşekkür Ederiz",
                        "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // mesaj onayından sonra geçerli formun kapatılması ve kullanıcı giriş formunun açılması

                    this.Close();
                    kullanici_girisi kg2 = new kullanici_girisi();
                    kg2.Show();

                }

            // e-mail adresi '@' ifadesi içermiyorsa kullanıcıya verilecek uyarı mesajı kısmı.
                else if(a.Contains("@") == false)
                {
                    MessageBox.Show("Geçersiz e-mail Adresi Girdiniz! Lütfen Kontrol Edip Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }
    }

