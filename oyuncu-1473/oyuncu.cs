using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyuncu_1473
{
    internal class oyuncu
    {
        public string Id    { get; set; }
        public string ad    { get; set; }
        public string soyad { get; set; }
        public string posta { get; set; }
        public double puan  { get; set; }
        public DateTime kayıtTarihi { get; set; }
        public bool aktif { get; set; }

    }
}
