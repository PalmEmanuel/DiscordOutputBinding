using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using PipeHow;

[assembly: WebJobsStartup(typeof(DiscordBindingStartup))]
namespace PipeHow
{
    public class DiscordBindingStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<DiscordBinding>();
        }
    }
}