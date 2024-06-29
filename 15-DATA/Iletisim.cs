using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_DATA
{
    public class Iletisim
    {
        public int IletisimID { get; set; }
        public string Eposta { get; set; }
        public string TelefonNo { get; set; }

        public string EvAdresi { get; set; }

        public int PersonelID { get; set; }

        public virtual Personel Personeliletisim { get; set; }

    }
}
