using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Portal___Login_Form
{

    public class InMemoryDB
    {
        public static List<User> Users = GenerateUser();

        private static List<User> GenerateUser()
        {

            //var user = new User()
            //{
            //    Id = 1,
            //    Active = true,
            //    Email = "admin@edu.fit.ba",
            //    FirstName = "Administrator",
            //    LastName = "FIT",
            //    Username = "admin",
            //    Password = "admin"
            //};

            //var list = new List<User>();
            //list.Add(user);
            //return list;

            return new List<User>()
            {
                new User()
                {
                    Id=1,
                    Active=true,
                    FirstName="Administrator",
                    LastName="FIT",
                    Username="admin",
                    Password=PasswordHash.hashPassword("admin")
                }

            };

            //implement password hashing
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
