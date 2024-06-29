using _15_DAL;
using _15_DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_UI
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
        AppDBContext context;
        Iletisim secilenPersonelIletisimi;
        private void Form2_Load(object sender, EventArgs e)
        {
            using (context = new AppDBContext())
            {
                List<Personel> personels = context.Personels.ToList();
                cbxPersonelListesi.DataSource = personels;
                cbxPersonelListesi.DisplayMember = "Ad";
                cbxPersonelListesi.ValueMember = "PersonelID";

            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (context = new AppDBContext())
            {
                if (cbxPersonelListesi.SelectedItem != null)
                {
                    int selectedId = (int)cbxPersonelListesi.SelectedValue;

                    secilenPersonelIletisimi = context.Iletisims.FirstOrDefault(x => x.PersonelID == selectedId);

                    if (secilenPersonelIletisimi != null)
                    {
                        txtEposta.Text = secilenPersonelIletisimi.Eposta;
                        txtEvAdresi.Text = secilenPersonelIletisimi.EvAdresi;
                        rtbTelefon.Text = secilenPersonelIletisimi.TelefonNo;
                        MessageBox.Show("Bilgiler Getirilmiştir");
                    }
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (context = new AppDBContext())
            {
                int selectedId = (int)cbxPersonelListesi.SelectedValue;

                
                secilenPersonelIletisimi.PersonelID = selectedId;
                secilenPersonelIletisimi.Eposta = txtEposta.Text;
                secilenPersonelIletisimi.EvAdresi = txtEvAdresi.Text;
                secilenPersonelIletisimi.TelefonNo=(string)rtbTelefon.Text;

                context.Iletisims.Update(secilenPersonelIletisimi);
                int result = context.SaveChanges();

                if (result == 1) { MessageBox.Show("Personel İletisim Bilgileri Güncellenmiştir."); }
                else
                {
                    MessageBox.Show("Personel İletisim Bilgileri Güncellenmemiştir.");
                }


            }
        }

        private void btnKayıtlar_Click(object sender, EventArgs e)
        {

        }
    }
}
