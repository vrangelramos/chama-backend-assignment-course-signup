using CourseSignUp.Api.Courses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Mediators
{
    public class SignupCommand : IRequest<string>
    {
        public SignUpToCourseDto SignUpToCourseDto { get; set; }
    }
}
