using LearningServer.ServiceInterface;
using ServiceStack;
using System;

namespace Server
{
    /// <summary>
    /// Main class for initializing AppHost as single instance(singleton)
    /// </summary>
    public static class Program
    {
        private class AppHost : AppSelfHostBase
        {
            public AppHost()
              : base("HttpListener Self-Host", typeof(CommentsService).Assembly) { }

            public override void Configure(Funq.Container container) { }
        }

        /// <summary>
        /// Main method with configuration for AppHost and database connection
        /// </summary>
        /// <param name="args">Option to give URI address to host on</param>
        static void Main(string[] args)
        {
            var listeningOn = args.Length == 0 ? "http://localhost:8888/" : args[0];
            var appHost = new AppHost()
                .Init()
                .Start(listeningOn);

            Console.WriteLine("AppHost Created at {0}, listening on {1}",
                DateTime.Now, listeningOn);

            Console.WriteLine("\nPress Space to exit...");
            Console.ReadKey();
        }
    }
}
