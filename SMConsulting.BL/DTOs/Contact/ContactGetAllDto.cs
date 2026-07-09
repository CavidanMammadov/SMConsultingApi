using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Contact
{
    public class ContactGetAllDto
    {
        public int ContactId { get; set; }
        public string ContactAdress { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public DateTime ContactCreatedAt { get; set; }
    }
}
