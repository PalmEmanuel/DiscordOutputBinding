using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;

namespace PipeHow
{
    [Extension("DiscordBinding")]
    public class DiscordBinding : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
        {
            context.AddConverter<string, DiscordMessage>(input => new DiscordMessage { content = input });
            context.AddBindingRule<DiscordAttribute>().BindToCollector(attr => new DiscordAsyncCollector(this, attr));
        }
    }
}