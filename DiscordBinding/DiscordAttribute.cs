using Microsoft.Azure.WebJobs.Description;
using System;

namespace PipeHow
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public class DiscordAttribute : Attribute
    {
        [ConnectionString(Default = "DiscordWebhookUrl")]
        public string DiscordWebhookUrl { get; set; }
    }
}