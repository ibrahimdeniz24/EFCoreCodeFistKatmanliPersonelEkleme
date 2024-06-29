

using _15_DAL;
using _15_DATA;

namespace _15_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AppDBContext context;
        private void Form1_Load(object sender, EventArgs e)
        {
            BirimEkle(cbxBirim);
        }

        private void BirimEkle(ComboBox cbxList)
        {
            List<string> list = new List<string>() { "Yazilim", "Muhasebe", "ERP", "Y�netim", "�nsan Kaynaklar�", "IT", "Pazarlama", "Sat��" };

            foreach (string s in list) { cbxList.Items.Add(s); }

        }

        private void Temizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtTCNo.Text = string.Empty;
            dtpDogumTarihi.Text = string.Empty;
            cbxBirim.Text = string.Empty;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (context = new AppDBContext())
            {
                try
                {


                    if ((string.IsNullOrWhiteSpace(txtAd.Text)) && (string.IsNullOrWhiteSpace(txtSoyad.Text)) && (string.IsNullOrWhiteSpace(txtTCNo.Text)))
                    {
                        MessageBox.Show("L�tfen *  i�aretlileri bo� b�rakmay�n. ");
                    }

                    else if (context.Personels.Any(c => c.TCKNO == txtTCNo.Text.Trim()))
                    {
                        MessageBox.Show("Ayn� isimde TCNO  vard�r. L�tfen Kontrol Ediniz ");
                    }
                    Personel personel = new Personel();

                    personel.Ad = txtAd.Text.Trim();
                    personel.Soyad = txtSoyad.Text.Trim();
                    personel.TCKNO = txtTCNo.Text.Trim();
                    personel.DogumTarihi = dtpDogumTarihi.Value;

                    if (cbxBirim.SelectedItem == null)
                    {
                        personel.Birim = null;
                    }
                    else
                    {
                        personel.Birim = cbxBirim.SelectedItem.ToString().Trim();
                    }


                    if (rdbErkek.Checked)
                    {
                        personel.Cinsiyet = rdbErkek.Text.Trim();
                    }
                    else if (rdbKadin.Checked)
                    {
                        personel.Cinsiyet = rdbKadin.Text.Trim();
                    }

                    context.Personels.Add(personel);
                    context.SaveChanges();

                    MessageBox.Show("Girilen Personel Kay�t Edilmi�tir");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($" Hata Mesaj� :{ex.Message}\nHata L�tfen Tekrar Deneyiniz");
                }

            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            this.Hide();
        }
    }
}

