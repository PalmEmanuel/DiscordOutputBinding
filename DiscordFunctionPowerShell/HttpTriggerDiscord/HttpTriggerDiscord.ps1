using namespace System.Net

param($Request, $TriggerMetadata)

$Message = $Request.Query.Message
if ($Message) {
    Push-OutputBinding -Name Discord -Value $Message
}

Push-OutputBinding -Name Response -Value ([HttpResponseContext]@{
    StatusCode = [HttpStatusCode]::OK
    Body = "Posted $Message to the Discord channel specified by the webhook."
})