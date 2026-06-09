using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCProjeAtlas.Models;
using SCProjeAtlas.Services;

namespace SCProjeAtlas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost]
        public async Task<IActionResult> Chat(ChatRequest chatRequest)
        {                      
            return Ok(await _chatService.ChatResponseAsync(chatRequest.Message));
        }
    }
}
