using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Blog
{
    public class BlogUpdateDto
    {
        public string BlogTitle { get; set; }
        public IFormFile? BlogMainImage { get; set; }
        public IFormFile? BlogSecondaryImage { get; set; }
        public string BlogMainContent { get; set; }
        public string BlogSubcontent { get; set; }
        public string BlogTags { get; set; }
    }
}
