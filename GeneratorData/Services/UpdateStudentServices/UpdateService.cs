using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConventionPractice.Core;
using ConventionPractice.Data;
using GeneratorData.Helpers.Constaints;
using Serilog;

namespace GeneratorData.Services.UpdateStudentServices
{
    public class UpdateService : IUpdateEmail
    {
        private readonly ApplicationDbContext _context;

        public UpdateService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void UpdateEmail()
        {

            IEnumerable<Student> students = _context.Students.ToList();
            foreach (Student student in students)
            {
                try
                {
                    string email = Utils.GenerateRandomEmail(10);
                    bool studentWithSimilarEmail = students.FirstOrDefault(s => s.Email == email) != null ? true : false;
                    if (!studentWithSimilarEmail)
                    {
                        student.Email = email;
                        _context.SaveChanges();

                        Log.Information($"Student {student.StudentId} has updated email {email}");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Error: {ex.Message}");
                }
            }
        }
    }
}