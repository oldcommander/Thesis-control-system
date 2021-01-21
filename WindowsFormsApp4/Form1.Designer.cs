namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_dosyasec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılKullanılırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dosyaTürüNeOlmalıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sistemGecikmesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telifHakkıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_giris = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(34, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1081, 483);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btn_dosyasec
            // 
            this.btn_dosyasec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_dosyasec.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyasec.Location = new System.Drawing.Point(838, 102);
            this.btn_dosyasec.Name = "btn_dosyasec";
            this.btn_dosyasec.Size = new System.Drawing.Size(138, 43);
            this.btn_dosyasec.TabIndex = 4;
            this.btn_dosyasec.Text = "Dosya Seç";
            this.btn_dosyasec.UseVisualStyleBackColor = false;
            this.btn_dosyasec.Click += new System.EventHandler(this.btn_dosyasec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem,
            this.lisansToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 31);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nasılKullanılırToolStripMenuItem,
            this.toolStripSeparator1,
            this.dosyaTürüNeOlmalıToolStripMenuItem,
            this.toolStripSeparator2,
            this.sistemGecikmesiToolStripMenuItem});
            this.yardımToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // nasılKullanılırToolStripMenuItem
            // 
            this.nasılKullanılırToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nasılKullanılırToolStripMenuItem.Name = "nasılKullanılırToolStripMenuItem";
            this.nasılKullanılırToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.nasılKullanılırToolStripMenuItem.Text = "Nasıl Kullanılır?";
            this.nasılKullanılırToolStripMenuItem.Click += new System.EventHandler(this.nasılKullanılırToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // dosyaTürüNeOlmalıToolStripMenuItem
            // 
            this.dosyaTürüNeOlmalıToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaTürüNeOlmalıToolStripMenuItem.Name = "dosyaTürüNeOlmalıToolStripMenuItem";
            this.dosyaTürüNeOlmalıToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.dosyaTürüNeOlmalıToolStripMenuItem.Text = " Dosya Türü Ne Olmalı?";
            this.dosyaTürüNeOlmalıToolStripMenuItem.Click += new System.EventHandler(this.dosyaTürüNeOlmalıToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // sistemGecikmesiToolStripMenuItem
            // 
            this.sistemGecikmesiToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sistemGecikmesiToolStripMenuItem.Name = "sistemGecikmesiToolStripMenuItem";
            this.sistemGecikmesiToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.sistemGecikmesiToolStripMenuItem.Text = "Sistem Gecikmesi";
            this.sistemGecikmesiToolStripMenuItem.Click += new System.EventHandler(this.sistemGecikmesiToolStripMenuItem_Click);
            // 
            // lisansToolStripMenuItem
            // 
            this.lisansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telifHakkıToolStripMenuItem});
            this.lisansToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lisansToolStripMenuItem.Name = "lisansToolStripMenuItem";
            this.lisansToolStripMenuItem.Size = new System.Drawing.Size(78, 27);
            this.lisansToolStripMenuItem.Text = "Lisans ";
            // 
            // telifHakkıToolStripMenuItem
            // 
            this.telifHakkıToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telifHakkıToolStripMenuItem.Name = "telifHakkıToolStripMenuItem";
            this.telifHakkıToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.telifHakkıToolStripMenuItem.Text = "Telif Hakkı";
            this.telifHakkıToolStripMenuItem.Click += new System.EventHandler(this.telifHakkıToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.piloToolStripMenuItem,
            this.güvenlikToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // piloToolStripMenuItem
            // 
            this.piloToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.piloToolStripMenuItem.Name = "piloToolStripMenuItem";
            this.piloToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.piloToolStripMenuItem.Text = "Pilot Uygulama";
            this.piloToolStripMenuItem.Click += new System.EventHandler(this.piloToolStripMenuItem_Click);
            // 
            // güvenlikToolStripMenuItem
            // 
            this.güvenlikToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güvenlikToolStripMenuItem.Name = "güvenlikToolStripMenuItem";
            this.güvenlikToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.güvenlikToolStripMenuItem.Text = "Güvenlik";
            this.güvenlikToolStripMenuItem.Click += new System.EventHandler(this.güvenlikToolStripMenuItem_Click);
            // 
            // lbl_giris
            // 
            this.lbl_giris.AutoSize = true;
            this.lbl_giris.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris.Location = new System.Drawing.Point(362, 46);
            this.lbl_giris.Name = "lbl_giris";
            this.lbl_giris.Size = new System.Drawing.Size(0, 23);
            this.lbl_giris.TabIndex = 8;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cikis.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(1010, 102);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(105, 43);
            this.btn_cikis.TabIndex = 9;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 668);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.lbl_giris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dosyasec);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tez Kontrol Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_dosyasec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_giris;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.ToolStripMenuItem nasılKullanılırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaTürüNeOlmalıToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sistemGecikmesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telifHakkıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenlikToolStripMenuItem;
    }
}

