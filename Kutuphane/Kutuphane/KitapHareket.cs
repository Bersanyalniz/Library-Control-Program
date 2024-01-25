using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class KitapHareket
    {
        public int KitapHareketId { get; set; }
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public DateTime VerilisTar { get; set; }
        public DateTime İadeTar { get; set; }
        public string Aciklama { get; set; }
        public bool AlinmaDurum { get; set; }
    }
}
