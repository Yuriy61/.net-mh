using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Quart
{
    public class MyQuartz
    {
        public void Start()
        {
            Common.Logging.LogManager.Adapter = new Common.Logging.Simple.ConsoleOutLoggerFactoryAdapter { Level = Common.Logging.LogLevel.Info };
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler(); //从工厂中获取一个调度器实例化
            scheduler.Start();   //开始调度器
            IJobDetail job = JobBuilder.Create<Job.RefreshTokenJob>().Build();//创建一个作业
            ITrigger trigger = TriggerBuilder.Create()
                .WithSimpleSchedule(t =>
                t.WithIntervalInHours(1) //触发执行，5s一次
                .RepeatForever())          //重复执行
                .Build();
            scheduler.ScheduleJob(job, trigger);       //把作业，触发器加入调度器。 

        }
    }
}