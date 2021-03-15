using CourseSignUp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Repositories
{
    public class SubscriptionRepository : IRepository<Subscription>
    {
        public Task Add(Subscription item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Subscription item)
        {
            throw new NotImplementedException();
        }

        public Task<Subscription> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Subscription> Get(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Subscription>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
