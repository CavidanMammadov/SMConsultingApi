using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class RefreshToken
    {
        public int RefreshTokenId { get; set; }
        public string RefreshTokenToken { get; set; }
        public int RefreshTokenUserId { get; set; }

        public DateTime RefreshTokenExpireTime { get; set; }
        public bool RefreshTokenIsRevoked { get; set; }
        public DateTime RefreshTokenCreatedAt { get; set; }
        public User User { get; set; }
    }
}
