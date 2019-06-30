using System;
using Volo.Abp;

namespace demoJobs.RabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var app = AbpApplicationFactory.Create<DemoAppMQMoudle> (options => {
                options.UseAutofac ();
            })) {
                app.Initialize ();

                Console.WriteLine ("Started: " + typeof (Program).Namespace);
                Console.WriteLine ("Press Enter to stop the application");
                Console.ReadLine ();

                app.Shutdown ();

            }
        }
    }
}
