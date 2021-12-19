using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor344.Models;

namespace Blazor344.Services
{
    public interface IStudentService
    {
         Task<IEnumerable<Student>> GetAll();
         Task<Student> GetById(int id);
         Task<Student> Add(Student Student);
         Task<Student> Update(int id, Student Student);
         Task Delete(int id);
    }
}