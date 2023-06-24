using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConventionPractice.Core
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateBirth { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}