using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.CardSpecifications
{
    public class CardSpecificationCreateDto
    {
        public string CardSpecificationTitle { get; set; }
        public IFormFile ? CardSpecificationIcon { get; set; }
        public List<string> CardSpecificationDescription { get; set; }
    }
}
