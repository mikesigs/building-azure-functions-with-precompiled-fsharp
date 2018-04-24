namespace MyFunctions

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc

module HelloYou =
    [<FunctionName("HelloYou")>]
    let run ([<HttpTrigger(Extensions.Http.AuthorizationLevel.Anonymous, "get", Route = "hello")>] req: HttpRequest) =
        ContentResult(Content = "Hello", ContentType = "text/html")