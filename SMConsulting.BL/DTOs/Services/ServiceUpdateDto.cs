using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Services
{
    public class ServiceUpdateDto
    {
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceFooter { get; set; }
        public string ServiceFooterDescription { get; set; }
    }
}
