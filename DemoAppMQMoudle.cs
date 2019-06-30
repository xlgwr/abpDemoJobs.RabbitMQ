using demo3;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs.RabbitMQ;
using Volo.Abp.Modularity;

namespace demoJobs {
    [DependsOn (
        typeof (AbpAutofacModule),
        typeof (AbpBackgroundJobsRabbitMqModule)
    )]
    public class DemoAppMQMoudle : AbpModule {
        public override void OnPostApplicationInitialization (Volo.Abp.ApplicationInitializationContext context) {
            context.ServiceProvider
                .GetRequiredService<SampleJobCreator> ()
                .CreateJobs ();
        }
        public override void OnApplicationInitialization (ApplicationInitializationContext context) {
            context
                .ServiceProvider
                .GetRequiredService<ILoggerFactory> ()
                .AddConsole (LogLevel.Debug);
        }
    }
}