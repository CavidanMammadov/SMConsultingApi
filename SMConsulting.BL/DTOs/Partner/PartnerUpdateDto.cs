using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Partner
{
    public class PartnerUpdateDto
    {
        public string PartnerName { get; set; }
        public string PartnerDescription { get; set; }
        public IFormFile? PartnerImage { get; set; }
        public string? PartnerWebsiteUrl { get; set; }
    }
}
