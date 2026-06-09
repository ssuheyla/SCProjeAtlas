using System.ComponentModel.DataAnnotations;

namespace SCProjeAtlas.Models
{
    public class ChatRequest
    {
        [Required(ErrorMessage = "Lütfen bir mesaj giriniz.")]
        public string Message { get; set; } = string.Empty;
    }
}
