using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConventionPractice.Core
{
    public class Grade
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Score? Score { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }

    public enum Score
    {
        A,B,C,D,E,G,Z,S,W,Q,P
    }
}