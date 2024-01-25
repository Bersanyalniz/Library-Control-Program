using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Kitap
    {
        public int KitapId { get; set; }

        public int UyeId { get; set; }
        public int YayineviId { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public DateTime VerilisTar { get; set; }
        public bool AlinmaDurum { get; set; }
    }
}
