# Architectural overview (knowledge of distributed services, cloud platforms)
- The CourseSignup.Api is the service to maintain signup requisitions from users. The future idea is to separate actual structure in small pieces, like a DDD (Separate in libraries like Presentation (Api Controllers), Service (Mediators folder), Infrastructure, ...)

# Explanation of solutions for both parts
- For the first part, was created the SignupCommandHandler to process CoursesController's requisitions, following the mediator recommendation to maintain low coupling between 'presentation' and domain. 
- For the second part, was created StatisticsCommandHandler to serve StatisticsController Requisitions. The idea here is to create an external scheduled job (an azure function) to consume this part of api (or separate this from main api) and show statistics course where necessary, every 5 secs for example.

# Test strategy for this solution (what to test)
- We could do integration tests doing some subscriptions and testing statistics after this subscriptions. 
- Create unit tests to validade every response type expected, to cover business logic

# What tools and technologies you used (libraries, framework, tools, storage types, cloud platform features)
- I just drafted a simple idea of solution, but we could improve using a log service to handle application errors, a mail service to handle some business alerts (ex: alert when a course is full) and main application errors. We could use azure functions to schedule statistics updates and save it into a different storage from the application that handle subscriptions (and use this storage to StatisticsController). Implement the repository with EF (or other library) to use transaction control when saving subscription and updating course number of students.

# What you think that it can be improved and how
- As I said before, separate project structure and adding the tecnologies above. 