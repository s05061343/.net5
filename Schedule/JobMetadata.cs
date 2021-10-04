using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public enum JobStatus : byte
    {
        [Description("初始化")]
        Init = 0,
        [Description("已排程")]
        Scheduled = 1,
        [Description("執行中")]
        Running = 2,
        [Description("已停止")]
        Stopped = 3,
    }

    public class JobMetadata
    {
        public string JobName { get; private set; }
        public Type JobType { get; private set; }
        public string CronExpression { get; private set; }
        public JobStatus JobStatus { get; set; } = JobStatus.Init;

        public JobMetadata(Type jobType, string cronExpression, string jobName)
        {
            JobType = jobType;
            CronExpression = cronExpression;
            JobName = jobName;
        }

        public IJobDetail CreateDetail()
        {
            var jobType = this.JobType;
            var jobDetail = JobBuilder
                .Create(jobType)
                .WithIdentity(this.JobName)
                .WithDescription(jobType.Name)
                .Build();

            // 可以在建立 job 時傳入資料給 job 使用
            jobDetail.JobDataMap.Put("Payload", this);
            return jobDetail;
        }

        public ITrigger CreateTrigger()
        {
            return TriggerBuilder
                .Create()
                .WithIdentity($"{this.JobName}.trigger")
                .WithCronSchedule(this.CronExpression)
                .WithDescription(this.CronExpression)
                .Build();
        }
    }
}
