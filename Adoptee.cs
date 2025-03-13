using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptMe___GROUP5
{
    internal class Adoptee: User
    {
        List<Adoptee> adopteeList = new List<Adoptee>();
        public Adoptee(int id, string email, string password, string name) : base(id, email, password, Role.Adoptee, name) { } 
        public void requestAnimal()
        {
            
        }
    }
}
