using CourseSignUp.Api.Models;
using CourseSignUp.Api.Repositories;
using CourseSignUp.Api.Statistics;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Mediators
{
    public class StatisticsCommandHandler : IRequestHandler<StatisticsCommand, CourseStatistics>
    {
        private readonly IRepository<Subscription> _subscriptionRepository;

        public StatisticsCommandHandler(IRepository<Subscription> subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }

        public Task<CourseStatistics> Handle(StatisticsCommand request, CancellationToken cancellationToken)
        {
            var subscriptions = _subscriptionRepository.GetAll().Result.Where(s => s.Course.IdCourse == request.IdCourse);

            var average = Convert.ToDecimal(subscriptions.Average(s => s.Student.Age));
            var minAge = subscriptions.Min(s => s.Student.Age);
            var maxAge = subscriptions.Max(s => s.Student.Age);

            var result = new CourseStatistics { AverageAge = average, MaximumAge = maxAge, MinimumAge = minAge };

            return Task.FromResult(result);
        }
    }
}
