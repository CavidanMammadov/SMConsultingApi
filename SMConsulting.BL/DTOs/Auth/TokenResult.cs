using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Auth
{
    public class TokenResult
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
