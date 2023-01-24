using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSearch
{
    public class Student
    {
        public int Id { get; set; }

        public string Index { get; set; }

        public int StudyYear { get; set; }

        public Image Picture { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
