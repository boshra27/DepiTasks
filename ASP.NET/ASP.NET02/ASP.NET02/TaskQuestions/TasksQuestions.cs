using Humanizer;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;

namespace ASP.NET02.TaskQuestions
{
    public class TasksQuestions
    {
        #region AutoMapper
        // AuthoMapper is a library that automatically maps between objects (Domain Model - View Model). It reduces reptitive
        // code, provide cleanaer controllers/services/ and centeralized mapping logic, It maps whatever is configured.
        #endregion

        #region What is the purpose of async/await keywords
        // They handle asynchronous (slow) operations without blocking the app, without async/await, the thread just waits
        // doing nothing (blocking), instead the thread is freed while waiting and the method is pause, thread can 
        // serve other requests and execution resumes when data is ready.
        #endregion

        #region Multiple page application and single page application
        // Multi-Page Application reloads the entire page every time the user navigates, each click is a new request to server
        // and full HTML reload , ex: ASP.NET MVC. Single-page Application load one HTML page once and updates content dynamically
        // using JS, ex: Backend: ASP.NET Web API, and a Frontend Framework.
        // We only proposed one project and it's our project Badil. There are two approaches that we can take first is a Hybrid 
        // approach MVC + JS because it has simple CRUD as well as highly interactive features (Notification - Messages), The second
        // approach is Full SPA (React + API) using backend and frontend separatly and we're most likely to go with this approach.

        #endregion

        #region Why do we need Architecture in any project?
        //Architecture organizes code into clear layers, making it easier to maintain, scale, and test.
        //It reduces duplication and keeps responsibilities separated.
        //Without it, projects become messy and hard to modify.
        #endregion

        #region What is N-tier Architecture?
        //It splits the application into layers like Presentation, Business Logic, and Data Access.
        //Each layer has a specific responsibility.
        //This improves maintainability and allows independent development.

        #endregion

        #region What is Onion Architecture?
        //It structures code in layers around a core domain, with dependencies pointing inward.
        //Business logic is independent from UI and database.
        //This makes the system more testable and flexible.
        #endregion

        #region Is LINQ slow in execution?
        // Not necessarily, LINQ uses deferred execution, meaning queries run only when needed.
        //Eager execution(like ToList()) runs immediately and may cost more memory/time.
        //Performance depends on how and when you execute the query.
        #endregion

        #region Three use cases we need asynchronous programming
        //Handling I/O operations(e.g., database or API calls).
        //Keeping UI responsive in apps.
        //Running multiple independent tasks concurrently to improve performance.
        #endregion

        #region What is the difference between thread and task
        //A Thread is a low-level OS unit of execution.
        //A Task is a higher-level abstraction that uses threads internally.
        //Tasks are easier to manage and support async/await.
        #endregion

        #region What is delegate built_in types in details
        // Action: no return value(0–16 parameters)
        //Func: returns a value(last type is return type)
        //Predicate: takes input and returns bool (used for filtering)
        //They simplify passing methods as parameters without custom delegates.
        #endregion
    }
}
