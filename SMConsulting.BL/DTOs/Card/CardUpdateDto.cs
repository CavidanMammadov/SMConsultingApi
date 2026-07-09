using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Card
{
    public class CardUpdateDto
    {
        public string CardTitle { get; set; }
        public string CardDescription { get; set; }
        public IFormFile CardIcon { get; set; }
    }
}
