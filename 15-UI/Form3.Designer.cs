namespace _15_UI
{
    partial class Form3
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
            lblPersonel = new Label();
            btnTemizle = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnTemizle2 = new Button();
            btnAnaMenü = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            btnAra = new Button();
            lstPersoneller = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPersonel
            // 
            lblPersonel.BorderStyle = BorderStyle.FixedSingle;
            lblPersonel.Location = new Point(38, 52);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(483, 340);
            lblPersonel.TabIndex = 0;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(38, 411);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(483, 71);
            btnTemizle.TabIndex = 1;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(lblPersonel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 501);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstPersoneller);
            groupBox2.Controls.Add(btnAra);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(btnTemizle2);
            groupBox2.Location = new Point(574, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(542, 501);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Bul";
            // 
            // btnTemizle2
            // 
            btnTemizle2.Location = new Point(38, 411);
            btnTemizle2.Name = "btnTemizle2";
            btnTemizle2.Size = new Size(486, 71);
            btnTemizle2.TabIndex = 1;
            btnTemizle2.Text = "TEMİZLE";
            btnTemizle2.UseVisualStyleBackColor = true;
            // 
            // btnAnaMenü
            // 
            btnAnaMenü.Location = new Point(12, 531);
            btnAnaMenü.Name = "btnAnaMenü";
            btnAnaMenü.Size = new Size(706, 92);
            btnAnaMenü.TabIndex = 4;
            btnAnaMenü.Text = "ANA MENÜ";
            btnAnaMenü.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(785, 533);
            button3.Name = "button3";
            button3.Size = new Size(331, 88);
            button3.TabIndex = 5;
            button3.Text = "Personel Bilgilerini Veritabanından Sil";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 28);
            comboBox1.TabIndex = 4;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(429, 26);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(95, 56);
            btnAra.TabIndex = 5;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // lstPersoneller
            // 
            lstPersoneller.FormattingEnabled = true;
            lstPersoneller.Location = new Point(38, 88);
            lstPersoneller.Name = "lstPersoneller";
            lstPersoneller.Size = new Size(481, 304);
            lstPersoneller.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 638);
            Controls.Add(button3);
            Controls.Add(btnAnaMenü);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPersonel;
        private Button btnTemizle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnTemizle2;
        private ListBox lstPersoneller;
        private Button btnAra;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnAnaMenü;
        private Button button3;
    }
}