using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Vision
    {
        public int VisionId { get; set; }
        public string VisionSubDescription { get; set; }
        public string VisionDescription { get; set; }
        public DateTime VisionCreatedAt { get; set; } = DateTime.Now;
    }
}
