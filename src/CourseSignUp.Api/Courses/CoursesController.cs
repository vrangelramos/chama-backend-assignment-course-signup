using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using MediatR;
using CourseSignUp.Api.Mediators;

namespace CourseSignUp.Api.Courses
{
    [ApiController, Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly IMediator _mediator;

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            // TODO
            return Ok(new CourseDto
            {

            });
        }

        [HttpPost, Route("create")]
        public Task<IActionResult> Post([FromBody] CreateCourseDto createCourseDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("sign-up")]
        public async Task<IActionResult> Post([FromBody] SignUpToCourseDto signUpToCourseDto)
        {
            var command = new SignupCommand { SignUpToCourseDto = signUpToCourseDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
