using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Applyment
    {
        public int AppylmentId { get; set; }
        public string ApplymentName { get; set; }
        public string ApplymentEmail { get; set; }
        public string ApplymentPhone { get; set; }
        public string  ApplymentCompany  { get; set; }
        public string ApplymentPosition { get; set; }
        public string ApplymentMessage { get; set; }
        public DateTime  ApplymentCreatedAt { get; set; } = DateTime.Now;
    }
}
