using Microsoft.Azure.WebJobs;

namespace PipeHow
{
    public static class HttpTriggerDiscord
    {
        [FunctionName("HttpTriggerDiscord")]
        public static string Run(
            [HttpTrigger] DiscordMessage message,
            [Discord] out DiscordMessage discordMessage)
        {
            discordMessage = message;

            return $"Posted \"{message.content}\" to the Discord channel specified by the webhook.";
        }
    }
}