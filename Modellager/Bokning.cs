using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Bokning
    {
        public int ID { get; set; }
        public int BokID { get; set; }
        public int MedlemID { get; set; }
        public DateTime StartDatum { get; set;  }
        public DateTime SlutDatum { get; set; }

        public Bokning()
        {

        }
    }
}
