using CourseSignUp.Api.Statistics;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Mediators
{
    public class StatisticsCommand : IRequest<CourseStatistics>
    {
        public int IdCourse { get; set; }
    }
}
