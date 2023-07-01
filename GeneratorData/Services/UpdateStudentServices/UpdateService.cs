using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ConventionPractice.Core;
using ConventionPractice.Data;
using GeneratorData.Helpers.Constaints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Serilog;

namespace GeneratorData.Services.UpdateStudentServices
{
    public class UpdateService : IUpdateEmail
    {
        private readonly ApplicationDbContext _context;
        private readonly IMemoryCache _caching;
        // Set cache options with expiration
        MemoryCacheEntryOptions cacheOptions = new MemoryCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(30))
            .SetAbsoluteExpiration(DateTimeOffset.Now.AddHours(2));

        public UpdateService(ApplicationDbContext context, IMemoryCache caching)
        {
            _context = context;
            _caching = caching;
        }

        public bool CheckIfEmailExist(string email)
        {
            var objValue = _caching.Get("lstEmailAsString");
            string lstEmailAsString = objValue != null ? objValue.ToString() : null;
            if (lstEmailAsString == null)
            {
                IEnumerable<string> lstEmail = _context.Students.Where(s => !string.IsNullOrEmpty(s.Email)).Select(s => s.Email).AsEnumerable();
                lstEmailAsString = string.Join(",", lstEmail);
                _caching.Set("lstEmailAsString", lstEmailAsString, cacheOptions);
            }

            if (lstEmailAsString.Contains(email))
            {
                return true;
            }

            lstEmailAsString = String.Concat(lstEmailAsString, email);
            _caching.Set("lstEmailAsString", lstEmailAsString, cacheOptions);

            return false;
        }

        public void UpdateEmail()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            IEnumerable<Student> students = _context.Students
                                                           .Where(s => string.IsNullOrEmpty(s.Email))
                                                           //    .Select(s => new Student { StudentId = s.StudentId, Email = s.Email })
                                                           .Take(500000);
            Log.Information($"Read Db {stopwatch.Elapsed}");

            int count = 0;
            List<Student> lstStudentUpdate = new List<Student>();
            foreach (Student student in students)
            {
                string email = Utils.GenerateRandomEmail(10);
                if (!CheckIfEmailExist(email))
                {
                    student.Email = email;
                    // lstStudentUpdate.Add(student);
                    if (count > 10000)
                    {
                        _context.SaveChanges();
                        Log.Information($"Number email edit {student.StudentId}");
                    }
                    count++;
                }
                else
                {
                    Log.Information($"Email Duplicate: {email}");
                }
            }
            stopwatch.Stop();
        }
    }
}