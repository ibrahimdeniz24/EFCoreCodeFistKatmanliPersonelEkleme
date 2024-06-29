namespace _15_UI
{
    partial class Form2
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
            label1 = new Label();
            cbxPersonelListesi = new ComboBox();
            btnGiris = new Button();
            groupBox1 = new GroupBox();
            btnKaydet = new Button();
            txtEvAdresi = new TextBox();
            label4 = new Label();
            rtbTelefon = new RichTextBox();
            label3 = new Label();
            txtEposta = new TextBox();
            label2 = new Label();
            btnYeniPersonel = new Button();
            btnKayıtlar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(381, 20);
            label1.TabIndex = 0;
            label1.Text = "İletişim Bilgilerini Tamamlamak İçin Bir Personel Seçiniz :";
            // 
            // cbxPersonelListesi
            // 
            cbxPersonelListesi.FormattingEnabled = true;
            cbxPersonelListesi.Location = new Point(37, 65);
            cbxPersonelListesi.Name = "cbxPersonelListesi";
            cbxPersonelListesi.Size = new Size(489, 28);
            cbxPersonelListesi.TabIndex = 0;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(37, 106);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(489, 98);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "GİRİS YADA GUNCELLEME YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(txtEvAdresi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(rtbTelefon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEposta);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(34, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 520);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Iletisim Bilgileri";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(277, 382);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(205, 127);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtEvAdresi
            // 
            txtEvAdresi.BorderStyle = BorderStyle.FixedSingle;
            txtEvAdresi.Location = new Point(165, 222);
            txtEvAdresi.Multiline = true;
            txtEvAdresi.Name = "txtEvAdresi";
            txtEvAdresi.Size = new Size(327, 147);
            txtEvAdresi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 235);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Ev Adresi :";
            // 
            // rtbTelefon
            // 
            rtbTelefon.BorderStyle = BorderStyle.FixedSingle;
            rtbTelefon.Location = new Point(165, 145);
            rtbTelefon.Name = "rtbTelefon";
            rtbTelefon.Size = new Size(324, 27);
            rtbTelefon.TabIndex = 3;
            rtbTelefon.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 152);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefonu :";
            // 
            // txtEposta
            // 
            txtEposta.BorderStyle = BorderStyle.FixedSingle;
            txtEposta.Location = new Point(165, 73);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(327, 27);
            txtEposta.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 75);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "E-Posta Adresi :";
            // 
            // btnYeniPersonel
            // 
            btnYeniPersonel.Location = new Point(24, 774);
            btnYeniPersonel.Name = "btnYeniPersonel";
            btnYeniPersonel.Size = new Size(223, 103);
            btnYeniPersonel.TabIndex = 7;
            btnYeniPersonel.Text = "YENİ PERSONEL";
            btnYeniPersonel.UseVisualStyleBackColor = true;
            btnYeniPersonel.Click += btnYeniPersonel_Click;
            // 
            // btnKayıtlar
            // 
            btnKayıtlar.Location = new Point(288, 774);
            btnKayıtlar.Name = "btnKayıtlar";
            btnKayıtlar.Size = new Size(235, 103);
            btnKayıtlar.TabIndex = 6;
            btnKayıtlar.Text = "TÜM KAYITLAR";
            btnKayıtlar.UseVisualStyleBackColor = true;
            btnKayıtlar.Click += btnKayıtlar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 900);
            Controls.Add(btnKayıtlar);
            Controls.Add(btnYeniPersonel);
            Controls.Add(groupBox1);
            Controls.Add(btnGiris);
            Controls.Add(cbxPersonelListesi);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxPersonelListesi;
        private Button btnGiris;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private TextBox txtEvAdresi;
        private Label label4;
        private RichTextBox rtbTelefon;
        private Label label3;
        private TextBox txtEposta;
        private Label label2;
        private Button btnYeniPersonel;
        private Button btnKayıtlar;
    }
}