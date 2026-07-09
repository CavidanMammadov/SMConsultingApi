using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Hero
{
    public class HeroCreateDto
    {
        public string HeroTitle { get; set; }
        public string HeroDescription { get; set; }
        public IFormFile  HeroImage { get; set; }

    }
}
