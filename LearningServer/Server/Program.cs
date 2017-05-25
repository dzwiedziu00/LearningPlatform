using LearningServer.ServiceInterface;
using ServiceStack;
using ServiceStack.Text;
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
              : base("HttpListener Self-Host", typeof(UsersService).Assembly) { }

            public override void Configure(Funq.Container container)
            {
                JsConfig<DateTime>.SerializeFn = time => new DateTime(time.Ticks, DateTimeKind.Local).ToString("o");
                JsConfig<DateTime?>.SerializeFn =
                    time => time != null ? new DateTime(time.Value.Ticks, DateTimeKind.Local).ToString("o") : null;
                JsConfig.DateHandler = DateHandler.ISO8601;
                JsConfig.IncludeNullValues = true;
                Plugins.Add(new CorsFeature());
            }
        }

        /// <summary>
        /// Main method with configuration for AppHost
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

            Console.ReadKey();
        }
    }
}
