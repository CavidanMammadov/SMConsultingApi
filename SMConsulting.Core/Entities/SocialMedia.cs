using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string SocialMediaFacebookUrl { get; set; }
        public string SocialMediaInstagramUrl { get; set; }
        public string SocialMediaLinekdinUrl { get; set; }
        public string SocialMediaYoutubeUrl { get; set; }
        public DateTime SocailMediaCreatedAt { get; set; } = DateTime.Now;
    }
}
