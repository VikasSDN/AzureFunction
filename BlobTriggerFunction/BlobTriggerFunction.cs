using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;


namespace AzureFunction.BlobTriggerFunction
{
   
    public static class BlobTriggerFunction
    {
        [FunctionName("BlobTriggerFunction")]
        public static void Run(
            [BlobTrigger("samples-workitems/{name}", Connection = "AzureWebJobsStorage")] Stream myBlob,
            string name,
            ILogger log)
        {
            log.LogInformation($"Blob trigger function processed blob\n Name: {name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
