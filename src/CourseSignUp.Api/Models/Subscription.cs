using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Models
{
    public class Subscription
    {
        public int IdSubscription { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public DateTime SubscriptionDate { get; set; }
    }
}
