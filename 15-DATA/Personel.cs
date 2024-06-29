using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_DATA
{
    public class Personel
    {
        public int PersonelID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TCKNO { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Cinsiyet { get; set; }

        public string Birim { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual Iletisim IletisimPersonel { get; set; }

        
    }
}
