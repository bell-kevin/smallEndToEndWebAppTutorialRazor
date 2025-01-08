<a name="readme-top"></a>

# Small end to end Web Application

https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio

bell@BellLaptop:~/RazorPagesMovie$ dotnet run --project RazorPagesMovie.csproj

http://localhost:5077/

![p](https://github.com/bell-kevin/cs3750smallEndToEndWebAppTutorialRazor/blob/main/Screenshots/Screenshot%20from%202024-09-04%2022-39-00.png)

![p](https://github.com/bell-kevin/cs3750smallEndToEndWebAppTutorialRazor/blob/main/Screenshots/Screenshot%20from%202024-09-04%2022-40-01.png)

Assignment 1 is an individual assignment.

Grading policy:

Assignment 1 will be graded based on attempt and not necessarily based on completion. You must finish one of the two tutorials mentioned below.  If you can complete the steps 1-4 in the To-Do list, you will definitely receive full credit. Any reasonable attempt to complete the assignment will also receive full credit. Our intention here is to appreciate and understand the complexity when we start putting all our knowledge together to build a tiny application. 

Tutorials:

Using Razor Page: 

https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio

Links to an external site.

 

Using MVC:

https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio

Links to an external site.

 

This is just one of the many available technologies. I highly encourage you to use the technology of your choice. As most students use .NET technologies in the class, let us at least attempt the tutorial. That way if you need to work with a team that use .NET technologies, it will be easier. 

 
Note:

This is not a CS2350 assignment. So, submitting only HTML files is not sufficient.

WPF is not Web.

Not providing a lot of technical details and resources to finish the assignment is intentional and purposeful. 

The first step to utilize any modern application is to create a user account and then to utilize the application using the account. Normally, most modern web application consists of 5 functionalities to provide user authentication and authorization.

    Sign Up – User will provide some basic information like name, username, email, password, etc. to create an account.
    Sign In – User will utilize the username and password to log in to the application.
    Reset Password Questions – Ask the user to enter answers to some basic questions that can be utilized to reset the password later.
    Forget Password (or Username) – Use the questions to make sure that the user is authentic and allow the user to reset password
    Reset password using email – send a token or temporary password to email and utilize it to reset password

For Assignment 1, we will implement (1) Sign Up and (2) Sign In. We will use the user’s email address as the username.
To-Do:

    Finish the tutorial. 
    Create a database to store all the necessary information. If you use the above mentioned technologies, it will be created using migration steps. 
    Create a home screen that consists of two text boxes. One for email and another for the password. Create a log in button that will allow the user to login. Upon successful login take them to a dummy welcome screen that states Welcome first name, last name. (First and last name of logged in user). In order to allow the user to login, you must check if that user exists in the database.
    Below the login button, add a new user sign up link that will take the user to sign up screen.
    SignUp screen consists of username/email, password, firstname, lastname, bithdate information and a button called SignUp. When User Sign up, take them to Welcome Screen. When user SignUp, all the information about the user should be stored in the database. You don't need to encrypt or hash the password. Just store the password as plain text for this assignment.
    Think of anything that can go wrong in this process and handle it. (Optional)

 
Submission:

    Finish one of the two tutorials (either Razor pages or MVC). Submit it as first_last_tutorial.zip. You just need to submit the code. You don't need to submit your database. I can run the migrations and  create the database. 
    Submit a video of usage of your application that demonstrates 5 steps in Canvas. You can just capture your screen and send me the video. 
    Submit a pdf or word document to describe the technology, programming languages, or any other components that you utilized. Also, please provide references to any online source code snippets or examples that you utilized.
    Submit your source code in the zip file in canvas.
    In case you are unable to complete the application, provide your zipped source code and also submit a word or pdf document explaining your attempt and what went wrong in the process. Adding as many details about your attempt will help me to grade your attempt accurately. 

 

 

 

Choose a submission type



--------------------------------------------------------------------------------------------------------------------------
== We're Using GitHub Under Protest ==

This project is currently hosted on GitHub.  This is not ideal; GitHub is a
proprietary, trade-secret system that is not Free and Open Souce Software
(FOSS).  We are deeply concerned about using a proprietary system like GitHub
to develop our FOSS project. I have a [website](https://bellKevin.me) where the
project contributors are actively discussing how we can move away from GitHub
in the long term.  We urge you to read about the [Give up GitHub](https://GiveUpGitHub.org) campaign 
from [the Software Freedom Conservancy](https://sfconservancy.org) to understand some of the reasons why GitHub is not 
a good place to host FOSS projects.

If you are a contributor who personally has already quit using GitHub, please
email me at **bellKevin@pm.me** for how to send us contributions without
using GitHub directly.

Any use of this project's code by GitHub Copilot, past or present, is done
without our permission.  We do not consent to GitHub's use of this project's
code in Copilot.

![Logo of the GiveUpGitHub campaign](https://sfconservancy.org/img/GiveUpGitHub.png)

<p align="right">(<a href="#readme-top">back to top</a>)</p>
