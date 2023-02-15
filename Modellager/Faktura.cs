using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Faktura
    {
        public int ID { get; set; } 
        public int BokningsID { get; set; }
        public decimal Summa { get; set; }
        public DateTime FakturaDatum { get; set; }

        public Faktura()
        {

        }
    }
}
