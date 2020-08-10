using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converters
{
    public class UsersConverter
    {

        public static DAL.Users ToDalUsers(Common.DTO.UsersDto users)
        {
            DAL.Users q1 = new DAL.Users();

            q1.user_email = users.user_email;
            q1.user_first_name = users.user_first_name;
            q1.user_id = users.user_id;
            q1.user_last_name = users.user_last_name;
            q1.user_password = users.user_password;
            q1.user_phone_number = users.user_phone_number;

            return q1;
        }
    }
}
