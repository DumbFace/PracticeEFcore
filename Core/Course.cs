using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConventionPractice.Core
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}