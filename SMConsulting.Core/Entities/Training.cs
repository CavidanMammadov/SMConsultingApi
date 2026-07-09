using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Training
    {
        public int TrainingId { get; set; }
        public string TrainingTitle { get; set; }
        public string TrainingDescription { get; set; }
        public DateTime TrainingCreatedAt { get; set; } = DateTime.Now;
    }
}
