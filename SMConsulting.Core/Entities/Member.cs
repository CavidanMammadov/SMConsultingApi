using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberFullName { get; set; }
        public string MemberPosition { get; set; }
        public string MemberImage{ get; set; }
        public string MemberPhone { get; set; }
        public string MemberEmail { get; set; }
        public string MemberDescription { get; set; }
        public DateTime MemberCreatedAt { get; set; } = DateTime.Now;
    }
}
