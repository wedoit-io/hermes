﻿namespace Apexnet.Dispatch.Api
{
    using System;
    using Apexnet.JobQueue;

    public class EnqueuedResponse : IEnqueued
    {
        public Guid Id { get; set; }
    }
}