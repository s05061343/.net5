using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Spi;
using Schedule.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Schedule
{
    public class QuartzHostedService : IHostedService
    {
        private readonly ISchedulerFactory _schedulerFactory;
        private readonly IJobFactory _jobFactory;
        private readonly ILogger<QuartzHostedService> _logger;
        private readonly IEnumerable<JobMetadata> _injectJobSchedules;
        public List<JobMetadata> _allJobSchedules;
        public IScheduler Scheduler { get; set; }
        public CancellationToken CancellationToken { get; private set; }

        public QuartzHostedService(
            ILogger<QuartzHostedService> logger, 
            ISchedulerFactory schedulerFactory, 
            IJobFactory jobFactory, 
            IEnumerable<JobMetadata> jobSchedules)
        {
            _logger = logger;
            _schedulerFactory = schedulerFactory;
            _jobFactory = jobFactory;
            _injectJobSchedules = jobSchedules;
            _allJobSchedules = new List<JobMetadata>();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                if (Scheduler == null || Scheduler.IsShutdown)
                {
                    CancellationToken = cancellationToken;
                    _allJobSchedules.AddRange(_injectJobSchedules);
                    // 初始排程器 Scheduler
                    Scheduler = await _schedulerFactory.GetScheduler(cancellationToken);
                    Scheduler.JobFactory = _jobFactory;
                    // 逐一將工作項目加入排程器中
                    _allJobSchedules.ForEach(async jobSchedule =>
                    {
                        await Scheduler.ScheduleJob(
                            jobSchedule.CreateDetail(),
                            jobSchedule.CreateTrigger(),
                            cancellationToken);
                        jobSchedule.JobStatus = JobStatus.Scheduled;
                    });

                    // 啟動排程
                    await Scheduler.Start(cancellationToken);
                }
            }
            catch (Exception ex)
            {
                var jex = new JobExecutionException(ex);
                jex.RefireImmediately = true;
                _logger.LogError($"@{jex}");
            }
        }

        /// <summary>
        /// 停止排程器
        /// </summary>
        /// <returns></returns>
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            if (Scheduler != null && !Scheduler.IsShutdown)
            {
                _logger.LogInformation($"@{DateTime.Now:HH:mm:ss} - Scheduler StopAsync");
                await Scheduler.Shutdown(cancellationToken);
            }
        }

        /// <summary>
        /// 取得所有作業的最新狀態
        /// </summary>
        public async Task<IEnumerable<JobMetadata>> GetJobSchedules()
        {
            if (Scheduler.IsShutdown)
            {
                // 排程器停止時更新各工作狀態為停止
                foreach (var jobSchedule in _allJobSchedules)
                {
                    jobSchedule.JobStatus = JobStatus.Stopped;
                }
            }
            else
            {
                // 取得目前正在執行的 Job 來更新各 Job 狀態
                var executingJobs = await Scheduler.GetCurrentlyExecutingJobs();
                foreach (var jobSchedule in _allJobSchedules)
                {
                    var isRunning = executingJobs.FirstOrDefault(j => j.JobDetail.Key.Name == jobSchedule.JobName) != null;
                    jobSchedule.JobStatus = isRunning ? JobStatus.Running : JobStatus.Scheduled;
                }
            }

            return _allJobSchedules;
        }

        /// <summary>
        /// 手動觸發作業
        /// </summary>
        public async Task TriggerJobAsync(string jobName)
        {
            if (Scheduler != null && !Scheduler.IsShutdown)
            {
                _logger.LogInformation($"@{DateTime.Now:HH:mm:ss} - job{jobName} - TriggerJobAsync");
                await Scheduler.TriggerJob(new JobKey(jobName), CancellationToken);
            }
        }

        /// <summary>
        /// 手動中斷作業
        /// </summary>
        public async Task InterruptJobAsync(string jobName)
        {
            if (Scheduler != null && !Scheduler.IsShutdown)
            {
                var targetExecutingJob = await GetExecutingJob(jobName);
                if (targetExecutingJob != null)
                {
                    _logger.LogInformation($"@{DateTime.Now:HH:mm:ss} - job{jobName} - InterruptJobAsync");
                    await Scheduler.Interrupt(new JobKey(jobName));
                }
            }
        }

        /// <summary>
        /// 取得特定執行中的作業
        /// </summary>
        private async Task<IJobExecutionContext> GetExecutingJob(string jobName)
        {
            if (Scheduler != null)
            {
                var executingJobs = await Scheduler.GetCurrentlyExecutingJobs();
                return executingJobs.FirstOrDefault(j => j.JobDetail.Key.Name == jobName);
            }

            return null;
        }
    }
}
