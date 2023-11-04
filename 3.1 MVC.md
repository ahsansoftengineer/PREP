1. Link for the Interview Questions?
	https://www.interviewbit.com/asp-net-interview-questions/

2. Middleware
Generate an HTTP response for an incoming HTTP request
Intercept and make changes to an incoming HTTP request and pass it on to the next piece of middleware.
Intercept and make changes to an outgoing HTTP response, and pass it on to the next piece of middleware.

What’s the HTTPContext object? How can you access it within a Controller?
HTTPContext encapsulates all HTTP-specific information about an individual HTTP request. You can access this object in controllers by using the ControllerBase.HttpContext property.

3. What are the different types that implement the IActionResult interface?
ASP.NET Core has many different types of IActionResult:

ViewResult—Generates an HTML view.
RedirectResult—Sends a 302 HTTP redirect response to send a user to a specified URL automatically.
RedirectToRouteResult—Sends a 302 HTTP redirect response to automatically send a user to another page, where the URL is defined using routing.
FileResult—Returns a file as the response.
ContentResult—Returns a provided string as the response.
StatusCodeResult—Sends a raw HTTP status code as the response, optionally with associated response body content.
NotFoundResult—Sends a raw 404 HTTP status code as the response.

7. What is a cookie?
A cookie is a small amount of data that is persisted across requests and even sessions. Cookies store information about the user. The browser stores the cookies on the user’s computer. Most browsers store the cookies as key-value pairs.
Response.Cookies.Append(key, value);
Response.Cookies.Delete(somekey);

Routing
There are two ways to define routes in an ASP.NET Core MVC application. 
Conventional Routing
Attribute-Based Routing.

Such back-end applications, which provide data, are commonly known as RESTful web services. REST protocol uses verbs like GET, POST, PUT, DELETE to communicate between multiple applications. The client and server can be written in different languages and technologies and still work together without knowing about each other, as long as each side knows the format of the data that is getting sent.
ASP.NET Core supports creating RESTful services, also known as web APIs, using C#. A Web API consists of one or more controllers that derive from ControllerBase class.
An MVC controller derives from the Controller class. However, a Web API controller should derive from the ControllerBase class. The reason is that Controller derives from ControllerBase and provides additional support for views, which you don’t need for web API requests.


Startup class contains two methods: ConfigureServices() and Configure(). As the name suggests, the first method registers all the services that the application needs. The second method configures the middleware pipeline.

