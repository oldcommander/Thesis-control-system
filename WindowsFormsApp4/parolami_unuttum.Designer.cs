namespace WindowsFormsApp4
{
    partial class parolami_unuttum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parolami_unuttum));
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_sifreYolla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_iptal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.ForeColor = System.Drawing.Color.Black;
            this.btn_iptal.Location = new System.Drawing.Point(145, 273);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(84, 45);
            this.btn_iptal.TabIndex = 0;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_sifreYolla
            // 
            this.btn_sifreYolla.BackColor = System.Drawing.Color.LightCyan;
            this.btn_sifreYolla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifreYolla.Location = new System.Drawing.Point(257, 274);
            this.btn_sifreYolla.Name = "btn_sifreYolla";
            this.btn_sifreYolla.Size = new System.Drawing.Size(99, 45);
            this.btn_sifreYolla.TabIndex = 0;
            this.btn_sifreYolla.Text = "MAİL GÖNDER";
            this.btn_sifreYolla.UseVisualStyleBackColor = false;
            this.btn_sifreYolla.Click += new System.EventHandler(this.btn_sifreYolla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Sisteme Kayıtlı E-Mail Adresinizi Aşağıdaki Alana Giriniz";
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(27, 187);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(469, 38);
            this.txt_mail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telif Hakları Gereği Kişisel Verileriniz Koruma Altındadır.";
            // 
            // parolami_unuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(534, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sifreYolla);
            this.Controls.Add(this.btn_iptal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "parolami_unuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parolamı Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_sifreYolla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label2;
    }
}