using SCProjeAtlas.Models;

namespace SCProjeAtlas.Services
{
    public interface IChatService
    {
        Task<ChatResponse> ChatResponseAsync(string chatRequest);
    }
}
