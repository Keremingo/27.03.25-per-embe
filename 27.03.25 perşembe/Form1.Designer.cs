namespace _27._03._25_perşembe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSalonAdı = new System.Windows.Forms.TextBox();
            this.TxtKoltukSayısı = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnoluştur = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chkİndirimli = new System.Windows.Forms.CheckBox();
            this.btnsatış = new System.Windows.Forms.Button();
            this.btniade = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbakiye = new System.Windows.Forms.Button();
            this.btnboşkoltuk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koltuk Sayısı";
            // 
            // TxtSalonAdı
            // 
            this.TxtSalonAdı.Location = new System.Drawing.Point(148, 21);
            this.TxtSalonAdı.Name = "TxtSalonAdı";
            this.TxtSalonAdı.Size = new System.Drawing.Size(144, 22);
            this.TxtSalonAdı.TabIndex = 2;
            this.TxtSalonAdı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtKoltukSayısı
            // 
            this.TxtKoltukSayısı.Location = new System.Drawing.Point(148, 60);
            this.TxtKoltukSayısı.Name = "TxtKoltukSayısı";
            this.TxtKoltukSayısı.Size = new System.Drawing.Size(144, 22);
            this.TxtKoltukSayısı.TabIndex = 3;
            this.TxtKoltukSayısı.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 476);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnoluştur
            // 
            this.btnoluştur.Location = new System.Drawing.Point(323, 24);
            this.btnoluştur.Name = "btnoluştur";
            this.btnoluştur.Size = new System.Drawing.Size(333, 58);
            this.btnoluştur.TabIndex = 5;
            this.btnoluştur.Text = "OLUŞTUR";
            this.btnoluştur.UseVisualStyleBackColor = true;
            this.btnoluştur.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(43, 294);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(0, 16);
            this.LblInfo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chkİndirimli);
            this.groupBox1.Controls.Add(this.btnsatış);
            this.groupBox1.Controls.Add(this.btniade);
            this.groupBox1.Location = new System.Drawing.Point(46, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLET SATIŞ-İADE";
            // 
            // Chkİndirimli
            // 
            this.Chkİndirimli.AutoSize = true;
            this.Chkİndirimli.Location = new System.Drawing.Point(11, 21);
            this.Chkİndirimli.Name = "Chkİndirimli";
            this.Chkİndirimli.Size = new System.Drawing.Size(91, 20);
            this.Chkİndirimli.TabIndex = 13;
            this.Chkİndirimli.Text = "İndirimli Mi";
            this.Chkİndirimli.UseVisualStyleBackColor = true;
            // 
            // btnsatış
            // 
            this.btnsatış.Enabled = false;
            this.btnsatış.Location = new System.Drawing.Point(11, 62);
            this.btnsatış.Name = "btnsatış";
            this.btnsatış.Size = new System.Drawing.Size(95, 37);
            this.btnsatış.TabIndex = 9;
            this.btnsatış.Text = "SATIŞ";
            this.btnsatış.UseVisualStyleBackColor = true;
            this.btnsatış.Click += new System.EventHandler(this.btnsatış_Click);
            // 
            // btniade
            // 
            this.btniade.Enabled = false;
            this.btniade.Location = new System.Drawing.Point(151, 62);
            this.btniade.Name = "btniade";
            this.btniade.Size = new System.Drawing.Size(95, 37);
            this.btniade.TabIndex = 10;
            this.btniade.Text = "İADE";
            this.btniade.UseVisualStyleBackColor = true;
            this.btniade.Click += new System.EventHandler(this.Chkiade_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbakiye);
            this.groupBox2.Controls.Add(this.btnboşkoltuk);
            this.groupBox2.Location = new System.Drawing.Point(357, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 152);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAPOR";
            // 
            // btnbakiye
            // 
            this.btnbakiye.Enabled = false;
            this.btnbakiye.Location = new System.Drawing.Point(191, 62);
            this.btnbakiye.Name = "btnbakiye";
            this.btnbakiye.Size = new System.Drawing.Size(91, 37);
            this.btnbakiye.TabIndex = 12;
            this.btnbakiye.Text = "BAKİYE";
            this.btnbakiye.UseVisualStyleBackColor = true;
            this.btnbakiye.Click += new System.EventHandler(this.btnbakiye_Click);
            // 
            // btnboşkoltuk
            // 
            this.btnboşkoltuk.Enabled = false;
            this.btnboşkoltuk.Location = new System.Drawing.Point(37, 62);
            this.btnboşkoltuk.Name = "btnboşkoltuk";
            this.btnboşkoltuk.Size = new System.Drawing.Size(106, 37);
            this.btnboşkoltuk.TabIndex = 11;
            this.btnboşkoltuk.Text = "BOŞ KOLTUK";
            this.btnboşkoltuk.UseVisualStyleBackColor = true;
            this.btnboşkoltuk.Click += new System.EventHandler(this.btnboşkoltuk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 476);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.btnoluştur);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TxtKoltukSayısı);
            this.Controls.Add(this.TxtSalonAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSalonAdı;
        private System.Windows.Forms.TextBox TxtKoltukSayısı;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnoluştur;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsatış;
        private System.Windows.Forms.Button btniade;
        private System.Windows.Forms.Button btnbakiye;
        private System.Windows.Forms.Button btnboşkoltuk;
        private System.Windows.Forms.CheckBox Chkİndirimli;
    }
}

