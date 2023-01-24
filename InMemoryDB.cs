using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSearch
{

    public class InMemoryDB
    {
        public static List<Student> Students = GenerateStudents();
        public static List<StudyYear> Years = GenerateYears();

        private static List<StudyYear> GenerateYears()
        {
            return new List<StudyYear>()
            {
                new StudyYear() {  Id=1, Description="I"},
                new StudyYear() {  Id=2, Description="II"},
                new StudyYear() {  Id=3, Description="III"},
                new StudyYear() {  Id=4, Description="IV"}
            };
        }

        private static List<Student> GenerateStudents()
        {

            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    Index="IB201564",
                    Active=true,
                    StudyYear=2020, 
                    FirstName="Administrator",
                    LastName="FIT",
                    Email="admin@fit.ba",
                    Password="admin"
                }

            };

        }
    }

}
