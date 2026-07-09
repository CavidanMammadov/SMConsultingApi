using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public int UserRole { get; set; } = 1;
        public string UserUserName { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserPasswordHash { get; set; }
        public DateTime UserCreatedAt { get; set; } = DateTime.Now;
        public bool UserIsAcTive { get; set; } = true;
    }
}
