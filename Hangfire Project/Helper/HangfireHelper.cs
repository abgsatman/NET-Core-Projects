using Hangfire;
using System;

namespace Hangfire_Project.Helper
{
    public static class HangfireHelper
    {
        public static void SetupRecurringJobs() {
            RecurringJob.AddOrUpdate(() => Console.WriteLine("A message from recurring job..."), Cron.Minutely);
        }
    }
}
