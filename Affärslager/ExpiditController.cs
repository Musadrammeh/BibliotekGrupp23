using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;

namespace Affärslager
{
    public class ExpiditController
    {
        List<string> myList = new List<string>();
        public static Expidit InloggadUser { get; set; }   
        public Expidit NyUser { get; set; }
        public Expidit (string UserName, string Password)
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
