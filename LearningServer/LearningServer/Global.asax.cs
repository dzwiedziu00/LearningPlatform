using Funq;
using LearningServer.Services.ServiceInterface;
using ServiceStack;
using System;

namespace LearningServer
{
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// Creates ServiceStack web service application with a singleton AppHost.
        /// </summary>
        private class LearningServerAppHost : AppHostBase
        {
            /// <summary>
            /// Initializes a new instance of your ServiceStack application, with the specified name and assembly containing the services.
            /// </summary>
            public LearningServerAppHost() : base("HelloRequestDto Web Services", typeof(CommentsService).Assembly) { }

            /// <summary>
            /// Configure the container with the necessary routes for your ServiceStack application.
            /// </summary>
            /// <param name="container">The built-in IoC used with ServiceStack.</param>
            public override void Configure(Container container)
            {
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            //Application initializer
            (new LearningServerAppHost()).Init();
        }
    }
}
