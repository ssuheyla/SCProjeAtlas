using SCProjeAtlas.Models;
using System.Globalization;

namespace SCProjeAtlas.Services
{
    public class ChatService : IChatService
    {
        public Task<ChatResponse> ChatResponseAsync(string chatRequest)
        {
            string response;          

            var lowerMessage = chatRequest.Trim().ToLower(new CultureInfo("tr-TR"));

            switch (lowerMessage)
            {
                case var x when x.Contains("merhaba") || x.Contains("selam"):
                    response = "Merhaba, size nasıl yardımcı olabilirim?";
                    break;
                case var x when x.Contains("nasılsın"):
                    response = "Teşekkür ederim. Size nasıl yardımcı olabilirim?";
                    break;
                case var x when x.Contains("yardım") || x.Contains("destek"):
                    response = "Tabii ki size nasıl yardımcı olabilirim?";
                    break;
                case var x when x.Contains("teşekkür") || x.Contains("sağ ol"):
                    response = "Rica ederim. Başka bir konuda size nasıl yardımcı olabilirim?";
                    break;
                default:
                    response = "Mesajınızı aldım, en kısa sürede yanıtlayacağım.";
                    break;
            }
            return Task.FromResult(new ChatResponse
            {
                Response = response
            });

        }
    }
}
