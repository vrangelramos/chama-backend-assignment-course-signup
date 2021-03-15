using CourseSignUp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public Task Add(Course item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Course item)
        {
            throw new NotImplementedException();
        }

        public Task<Course> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> Get(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Course>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
