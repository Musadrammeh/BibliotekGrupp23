using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;

namespace Affärslager
{
    public class ExpeditController
    {
        List<string> myList = new List<string>();
        public static Expidit InloggadUser { get; set; }   
        public Expidit NyUser { get; set; }
        public ExpeditController (string UserName, string Password)
        {
            IEnumerable<Expidit> Expiditer = Repository.Context.ExpiditRepository.GetALL();
            foreach(Expidit e in Expiditer)
            {
                if(UserName == e.UserName && e.VertifyPassword(Password) 
                {
                    InloggadUser= e;
                    return InloggadUser;
                
                }
                return InloggadUser;
            }
        }

    }
}
