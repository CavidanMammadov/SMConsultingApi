using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Difficulty
{
    public class DifficultyGetAllDto
    {
        public int DifficultyId { get; set; }
        public string DifficultyDescription { get; set; }
        public int DifficultSectorHelpId { get; set; }
        public DateTime DifficultyCreatedAt { get; set; } 
    }
}
