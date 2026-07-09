using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Card
{
    public class CardGetAllDto
    {
        public int CardId { get; set; }
        public string CardTitle { get; set; }
        public string CardDescription { get; set; }
        public string CardIcon { get; set; }
        public DateTime CardCreatedAt { get; set; } = DateTime.Now;
    }
}
