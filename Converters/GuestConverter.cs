using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converters
{
    public class GuestConverter
    {
        public static DAL.Guest ToDalGuest(Common.DTO.GuestDto guest)
        {
            DAL.Guest q1 = new DAL.Guest();

            q1.guest_email = guest.guest_email;
            q1.guest_first_name = guest.guest_first_name;
            q1.guest_id = guest.guest_id;
            q1.guest_last_name = guest.guest_last_name;
            q1.guest_message_after = guest.guest_message_after;
            q1.guest_message_befor = guest.guest_message_befor;
            q1.guest_tz = guest.guest_tz;
            q1.gender = guest.gender;
            q1.table_id = guest.table_id;
            q1.guest_catagory_id = guest.guest_catagory_id;

            return q1;
        }
    }
}
