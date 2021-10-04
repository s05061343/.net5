using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Model.Sqlite;
using Newtonsoft.Json;
using Quartz;
using Service.ShortenUrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Jobs
{
    public class CheckExpiredJob : IJob
    {
        private readonly ILogger<CheckExpiredJob> _logger;
        private readonly IServiceProvider _provider;

        public CheckExpiredJob(
            ILogger<CheckExpiredJob> logger, 
            IServiceProvider provider)
        {
            _provider = provider;
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            // 可取得自定義的 JobSchedule 資料, 可根據 JobSchedule 提供的內容建立不同 report 資料
            var schedule = context.JobDetail.JobDataMap.Get("Payload") as JobMetadata;
            var jobName = schedule.JobName;

            using (var scope = _provider.CreateScope())
            {
                var _manager = scope.ServiceProvider.GetService<IShortenUrlManager>();
                var url = _manager.Shorten("https://www.quartz-scheduler.net/documentation/quartz-3.x/packages/aspnet-core-integration.html");
                _logger.LogInformation($"@{DateTime.Now:HH:mm:ss} - job:{jobName} - working({JsonConvert.SerializeObject(url)})");
                _logger.LogInformation($"@{DateTime.Now:HH:mm:ss} - job:{jobName} - done");
            }
            return Task.CompletedTask;
        }
    }
}
