using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Medlem
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsExpidit { get; set; }

        public Medlem() 
        {
        
        }
    }
}
