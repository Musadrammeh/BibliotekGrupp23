using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Böcker
    {
        public int ID { get; set; } 
        public string BokTitel { get; set; }    
        public string Författare { get; set; }  
        public string ISBNnummer { get; set; }  
        public string Information { get; set; }  
        public bool Finns { get; set; } 

        public Böcker()
        {

        }
        
    }
}