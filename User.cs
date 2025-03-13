using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptMe___GROUP5
{
        internal abstract class User
        {
            public int Id { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

            public enum Role
            {
                Admin,
                Adoptee
            }

            public Role IsRole { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }

            public User(int id, string email, string password, Role isRole, string name)
            {
                this.Id = id;
                this.Email = email;
                this.Password = password;
                this.IsRole = isRole;
                this.Name = name;
            }
        }
 }
