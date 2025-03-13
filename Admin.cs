using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptMe___GROUP5
{
    internal class Admin: User
    {
        List<Admin> adminlist = new List<Admin>();
        public Admin (int id, string email, string password, string name):
            base (id, email, password, Role.Admin, name){}

        public void addAnimal()
        {
        
        }
        public void removeAnimal()
        {
            
        }
        public void manageAnimal()
        {

        }
        public void approveRequest()
        {

        }

        public void declineRequest()
        {

        }
    }
}
