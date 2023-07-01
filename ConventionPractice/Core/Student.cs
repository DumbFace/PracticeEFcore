using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ConventionPractice.Core
{
    public class Student 
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        [NotNull]
        public string Email { get; set; }
        public DateTime? DateBirth { get; set; }
        public Gender? Gender { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        public ICollection<Grade>? Grades { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}