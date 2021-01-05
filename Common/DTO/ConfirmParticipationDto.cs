using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class ConfirmParticipationDto
    {
        public int table_members_id { get; set; }
        public int guest_id { get; set; }
        public int friend_id { get; set; }
        public bool like_or_not { get; set; }
    }
}
