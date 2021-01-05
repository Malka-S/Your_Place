using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converters
{
    public class ConfirmParticipationConverter
    {
        public static DAL.guest_table_member ToDalConfirmParticipation(Common.DTO.ConfirmParticipationDto cp)
        {
            DAL.guest_table_member q1 = new DAL.guest_table_member();

            //q1.friend_id = gtm.friend_id;
            //q1.like_or_not = gtm.like_or_not;
            q1.table_members_id = cp.table_members_id;

            return q1;
        }
    }
}
