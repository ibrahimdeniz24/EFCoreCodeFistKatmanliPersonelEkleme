namespace _15_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpboxForm1 = new GroupBox();
            cbxBirim = new ComboBox();
            rdbKadin = new RadioButton();
            rdbErkek = new RadioButton();
            dtpDogumTarihi = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTCNo = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            btnTemizle = new Button();
            btnKaydet = new Button();
            btnIletisim = new Button();
            grpboxForm1.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxForm1
            // 
            grpboxForm1.Controls.Add(cbxBirim);
            grpboxForm1.Controls.Add(rdbKadin);
            grpboxForm1.Controls.Add(rdbErkek);
            grpboxForm1.Controls.Add(dtpDogumTarihi);
            grpboxForm1.Controls.Add(label6);
            grpboxForm1.Controls.Add(label5);
            grpboxForm1.Controls.Add(label4);
            grpboxForm1.Controls.Add(label3);
            grpboxForm1.Controls.Add(label2);
            grpboxForm1.Controls.Add(label1);
            grpboxForm1.Controls.Add(txtTCNo);
            grpboxForm1.Controls.Add(txtSoyad);
            grpboxForm1.Controls.Add(txtAd);
            grpboxForm1.Location = new Point(24, 12);
            grpboxForm1.Name = "grpboxForm1";
            grpboxForm1.Size = new Size(507, 571);
            grpboxForm1.TabIndex = 0;
            grpboxForm1.TabStop = false;
            grpboxForm1.Text = "Personel Kayıt Ekranı";
            // 
            // cbxBirim
            // 
            cbxBirim.FormattingEnabled = true;
            cbxBirim.Location = new Point(178, 490);
            cbxBirim.Name = "cbxBirim";
            cbxBirim.Size = new Size(292, 28);
            cbxBirim.TabIndex = 5;
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(353, 407);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(68, 24);
            rdbKadin.TabIndex = 4;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadin";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(178, 407);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(65, 24);
            rdbErkek.TabIndex = 4;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(178, 298);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(292, 27);
            dtpDogumTarihi.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 491);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 1;
            label6.Text = "Birimi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 408);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 1;
            label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 302);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 1;
            label4.Text = "Dogum Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 225);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 1;
            label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 149);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 85);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Adı :";
            // 
            // txtTCNo
            // 
            txtTCNo.BorderStyle = BorderStyle.FixedSingle;
            txtTCNo.Location = new Point(178, 219);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(292, 27);
            txtTCNo.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Location = new Point(178, 142);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(292, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Location = new Point(178, 78);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(292, 27);
            txtAd.TabIndex = 0;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(30, 595);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(198, 86);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "TEMİZLE ";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(299, 595);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(195, 86);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "KAYDET ";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIletisim
            // 
            btnIletisim.Location = new Point(30, 702);
            btnIletisim.Name = "btnIletisim";
            btnIletisim.Size = new Size(464, 82);
            btnIletisim.TabIndex = 8;
            btnIletisim.Text = "İLETİSİM BİLGİLERİNİ GÖR";
            btnIletisim.UseVisualStyleBackColor = true;
            btnIletisim.Click += btnIletisim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 804);
            Controls.Add(btnIletisim);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(grpboxForm1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpboxForm1.ResumeLayout(false);
            grpboxForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxForm1;
        private DateTimePicker dtpDogumTarihi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTCNo;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private ComboBox cbxBirim;
        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private Label label6;
        private Button btnTemizle;
        private Button btnKaydet;
        private Button btnIletisim;
    }
}
