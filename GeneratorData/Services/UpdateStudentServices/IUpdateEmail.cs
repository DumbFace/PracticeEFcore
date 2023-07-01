using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorData.Services.UpdateStudentServices
{
    public interface IUpdateEmail
    {
        void UpdateEmail();
        bool CheckIfEmailExist(string email);
    }
}