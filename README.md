# AzureFunction

## Function Types and Implementation

### 1. HTTP Trigger Function

__Purpose:__ The HTTP Trigger allows us to run Azure Functions when an HTTP request is received. It's ideal for exposing your function as an API endpoint.
__Files:__ Function1.cs, HttpTriggerFunction.cs

#### How to integrate it:-  

- Add the [HttpTrigger] attribute to a function parameter.

- Define allowed HTTP methods (GET, POST, etc.).

- Use dependency injection for services like logging or DB context.

### 2.Timer Trigger Function

__Purpose:__ The Timer Trigger runs on a schedule you define using a CRON expression. It’s useful for background tasks that must run at intervals.
__Files:__ Function1.cs, HttpTriggerFunction.cs

#### How to integrate it:-

- Use [TimerTrigger] with a CRON string like "0 */5* ** *" (every 5 minutes).

- Inject services like ILogger, HttpClient, or database context.

#### 3.Blob Trigger Function

__Purpose:__ A Blob Trigger function runs when a new blob (file) is added or modified in a specified container in Azure Blob Storage.
__Files:__ BlobTriggerFunction.cs

#### How to integrate it:-

- Use [BlobTrigger] with a path pattern like "my-container/{name}".

- Bind the blob content to a Stream, string, or CloudBlockBlob.

##### Implementation Patterns:-  

- Chain with Queue Triggers for decoupled processing .

- Use Durable Functions for orchestration.

### Functions and there use cases:-  

| Trigger Type | Triggers On | Ideal For | Key Tools/Integrations |
| ------------ | ----------- | --------- | ---------------------- |
| HTTP Trigger | HTTP GET/POST | APIs, Webhooks | Frontend apps, API Gateways, Auth |
| Timer Trigger | Scheduled CRON | Background Jobs | Email, Cleanup, Reporting |
| Blob Trigger | Blob Upload/Change | File Processing | Azure Blob, Stream, Logging |
