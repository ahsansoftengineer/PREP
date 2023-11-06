It seems like you might be referring to running scheduled jobs or tasks in a .NET Core application using a scheduler similar to cron jobs in Unix-like systems. In .NET Core, you can achieve this using various libraries, but one common approach is to use a package like `Hangfire` or `Quartz.NET`. These libraries allow you to schedule and run background jobs at specified times or intervals.

Here's a brief overview of using Hangfire in a .NET Core application:

1. Install the Hangfire package:

   You can add the Hangfire package to your .NET Core project using the following command:

   ```bash
   dotnet add package Hangfire
   ```

2. Configure Hangfire in your `Startup.cs`:

   In your `Startup.cs` file, configure Hangfire to use your preferred storage system (e.g., SQL Server, Redis) and set up the Hangfire dashboard for monitoring jobs.

   ```csharp
   services.AddHangfire(configuration => configuration
       .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
       .UseSimpleAssemblyNameTypeSerializer()
       .UseRecommendedSerializerSettings()
       .UseSqlServerStorage(Configuration.GetConnectionString("YourDatabaseConnectionString")));

   services.AddHangfireServer();

   // Configure recurring jobs here
   RecurringJob.AddOrUpdate(() => YourJobMethod(), Cron.Daily);
   ```

3. Create a method for the job you want to schedule:

   Define a method that represents the job you want to run at the scheduled intervals.

   ```csharp
   public void YourJobMethod()
   {
       // Your job logic here
   }
   ```

4. Run the Hangfire dashboard:

   To monitor and manage your scheduled jobs, run the Hangfire dashboard using the following code in your `Main` method or wherever appropriate:

   ```csharp
   app.UseHangfireDashboard();
   ```

5. Start the Hangfire background processing:

   In your `Main` method, make sure to start the Hangfire background processing:

   ```csharp
   app.UseHangfireServer();
   ```

Now, your .NET Core application is configured to run scheduled background jobs using Hangfire. You can monitor and manage these jobs through the Hangfire dashboard.

This is just one example, and there are other scheduling libraries and approaches you can use in .NET Core based on your specific requirements. Hangfire and Quartz.NET are popular choices for implementing scheduled jobs in .NET Core applications.