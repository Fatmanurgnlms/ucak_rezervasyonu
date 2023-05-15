using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucak_rezervasyonu
{
    internal class rezervasyon
    {
        public string Ucak { get; set; }
        public string Lokasyon { get; set; }
        public string Müsteri { get; set; }
        public string KoltukNo { get; set; }
        public char Acik;
        public char Kapali;
        public int doluKoltuk;
        public int bosKoltuk;
        public DateTime TarihVeSaat;

    }
}
