using Microsoft.AspNetCore.Http;

namespace SMConsulting.BL.DTOs.Card
{
    public class CardCreateDto
    {
        public string CardTitle { get; set; }
        public string CardDescription { get; set; }
        public IFormFile CardIcon { get; set; }
    }
}
