using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunction.TimerTriggerFunction
{
    public static class TimerTriggerFunction
    {
        [FunctionName("TimerTriggerFunction")]
        public static void Run(
            [TimerTrigger("0 */1 * * * *")] TimerInfo myTimer,
            ILogger log)
        {
            log.LogInformation($"Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
