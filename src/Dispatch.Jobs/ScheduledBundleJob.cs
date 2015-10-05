﻿namespace Apexnet.Dispatch.Jobs
{
    using System;
    using System.Linq.Expressions;
    using Apexnet.Dispatch.Api;
    using Apexnet.JobQueue;
    using Apexnet.JobQueue.JobQueues;

    public class ScheduledBundleJob : BaseBundleJob, ISchedulable
    {
        private readonly ScheduledBundleRequest request;

        public ScheduledBundleJob(ScheduledBundleRequest request)
            : base(new HangfireJobsManager())
        {
            this.request = request;
        }

        public override Expression<Action> Operation
        {
            get
            {
                return () => this._Run(this.request);
            }
        }

        public DateTimeOffset Schedule
        {
            get
            {
                return this.request.Schedule;
            }
        }
    }
}