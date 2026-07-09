using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Auth
{
    public class JwtDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public string FullName { get; set; }
    }
}
