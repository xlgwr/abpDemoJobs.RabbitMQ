using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;

namespace demo3 {
    public class SampleJobCreator : ITransientDependency {
        private readonly IBackgroundJobManager _backgroundJobManager;

        public SampleJobCreator (IBackgroundJobManager backgroundJobManager) {
            _backgroundJobManager = backgroundJobManager;
        }

        public void CreateJobs () {
            _backgroundJobManager.Enqueue (new WriteToConsoleGreenJobArgs { Value = "test 1 (green)" },BackgroundJobPriority.Low, System.TimeSpan.FromSeconds(30));
            _backgroundJobManager.Enqueue (new WriteToConsoleGreenJobArgs { Value = "test 2 (green)" },BackgroundJobPriority.High, System.TimeSpan.FromSeconds(32));
            _backgroundJobManager.Enqueue (new WriteToConsoleYellowJobArgs { Value = "test 1 (yellow)" },BackgroundJobPriority.Low, System.TimeSpan.FromSeconds(40));
            _backgroundJobManager.Enqueue (new WriteToConsoleYellowJobArgs { Value = "test 2 (yellow)" },BackgroundJobPriority.High, System.TimeSpan.FromSeconds(52));
            
        }
    }
}