using CourseSignUp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public Task Add(Student item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Student item)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Get(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
