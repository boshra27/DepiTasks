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
    }
}
