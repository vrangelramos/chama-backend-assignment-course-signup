# Assignment: Course Sign-up System

Below assignment consists of 3 parts. We expect you to work about 5 hours on
this assignment.

Note that 5 hours is not enough to finish the whole assignment properly. 
For the parts that you did not get to, you should be able to explain how you would approach 
them, what problems you expect and what techniques you would apply to solve these 
problems.

We expect you to showcase your skills in some (or all) of the following areas:
- Dependency Injection
- Writing testable code
- Exception handling and logging
- Asynchronous code (when and how (not) to use async/await)
- Asynchrony through messaging (events, commands)
- Web API + OWIN
- Storage technologies available on the Azure platform (SQL, Table Storage, Cosmos DB, ...)

Please upload the code of the assignment at least 24 hours before you present 
it. 

## Case description

You start working at a company that offers online courses.

For each of the courses, there is one teacher/lecturer, and for each of the courses
there is a maximum number of students that can participate. 

To sign up, students need to supply their name and their age.

## Part 1: API for signing up

Create an API endpoint with which students can sign up for a course. 

If a course is full, it should not be possible to sign up any more.

The endpoint's response should indicate whether signing up was successful.

## Part 2: Scaling out

After few months, the company's courses grow wildly successfull, business is 
booming. There are many courses and millions of sign ups, and your synchronous API 
cannot handle the load any more.

Create a new endpoint for your API that defers the actual processing to a 
worker process: signing up is processed asynchronously.

This works as follows. The API puts a command message on a queue, and the 
message is picked up by the worker process. The worker process tries to sign 
up the student; it then sends an e-mail to inform the student whether signing 
up succeeded.

You can implement "sending an email" with a mock implementation that logs 
success or failure. 

## Part 3: Querying

For analysis purposes, the company needs to know per course the minimum age, the
maximum age and the average age of students that signed up for the course.

Create an API endpoint that gives exactly this information. Consider that this needs
to keep working efficiently when there are millions of sign-ups per day:
calculating this information at every request is unfeasable.

