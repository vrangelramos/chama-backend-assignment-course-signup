using CourseSignUp.Api.Models;
using CourseSignUp.Api.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Mediators
{
    public class SignupCommandHandler : IRequestHandler<SignupCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Subscription> _subscriptionRepository;
        private readonly IRepository<Student> _studentRepository;
        private readonly IRepository<Course> _courseRepository;

        public SignupCommandHandler(IMediator mediator, IRepository<Subscription> subscriptionRepository, IRepository<Student> studentRepository, IRepository<Course> courseRepository)
        {
            _mediator = mediator;
            _subscriptionRepository = subscriptionRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        public async Task<string> Handle(SignupCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var course = _courseRepository.Get(int.Parse(request.SignUpToCourseDto.CourseId)).Result;
                if(course.IsFull())
                    return await Task.FromResult("Sorry, course is full.");

                var student =_studentRepository.Get(request.SignUpToCourseDto.Student.Name).Result;
                var subscription = new Subscription { SubscriptionDate = DateTime.Now, Course = course, Student = student};                

                //TODO: Do changes in the same transaction
                await _subscriptionRepository.Add(subscription);
                course.NumberOfStudents += 1;
                await _courseRepository.Edit(course);

                await _mediator.Publish(new SignupNotification { Success = true });

                return await Task.FromResult("Congrats, subscription finalized.");
            }
            catch (Exception ex)
            {
                await _mediator.Publish(new SignupNotification { Success = false });
                //await _mediator.Publish(new ErrorNotification { Excecao = ex.Message, Stack = ex.StackTrace });
                return await Task.FromResult("Internal error. Try again.");
            }
        }
    }
}
