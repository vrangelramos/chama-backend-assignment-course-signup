using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Models
{
    public class Course
    {
        public int IdCourse { get; set; }
        public int Capacity { get; set; }
        public int NumberOfStudents { get; set; }

        internal bool IsFull()
        {
            return Capacity == NumberOfStudents;
        }
    }
}
