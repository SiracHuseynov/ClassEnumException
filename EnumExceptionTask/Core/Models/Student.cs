using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        private static int _id;
        public int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public ClassType ClassTypes { get; set; }

        public Student(string name, string surname, ClassType classTypes)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            ClassTypes = classTypes;
        }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Surname: {Surname}; Class Type: {ClassTypes}";
        }
    }
}
