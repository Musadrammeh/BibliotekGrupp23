using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Expedit: Person
    {
        public int AnställningsID { get; private set; }
        private string Password;

        public Expidit(int anställningsid, string password, string fnamn) 
        {
            AnställningsID = anställningsid;
            this.Password = password;
            Fnamn = fnamn; 
        }
        public bool VerifyPassword(string input)
        {
            return Password == input;
        }

    }
}
