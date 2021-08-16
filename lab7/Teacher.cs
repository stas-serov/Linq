using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Teacher
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public DateTime birth_date { get; set; }
        public string cathedra { get; set; }
        public string position { get; set; }
        public int experience { get; set; }
        public int salary { get; set; }
        public Teacher (int id, string name, string surname, string patronymic, DateTime birth_date, string cathedra, string position, int experience, int salary)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.birth_date = birth_date;
            this.cathedra = cathedra;
            this.position = position;
            this.experience = experience;
            this.salary = salary;
        }
    }
}
