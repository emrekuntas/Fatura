using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatura
{
    public class secilenUrun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Miktar { get; set; }
        public decimal urunFiyat { get; set; }
        public decimal toplamTutar { get; set; }
        public decimal Kdv { get; set; }

    }
}
