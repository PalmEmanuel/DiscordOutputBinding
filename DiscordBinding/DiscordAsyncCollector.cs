using Microsoft.Azure.WebJobs;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace PipeHow
{
    internal class DiscordAsyncCollector : IAsyncCollector<DiscordMessage>
    {
        private static HttpClient _client = new HttpClient();
        private string _webhookUrl;

        public DiscordAsyncCollector(DiscordBinding config, DiscordAttribute attr)
        {
            _webhookUrl = attr.DiscordWebhookUrl;
        }

        public async Task AddAsync(DiscordMessage message, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _client.PostAsync(_webhookUrl, new StringContent(JsonSerializer.Serialize(message), Encoding.UTF8, "application/json"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.CompletedTask;
        }
    }
}