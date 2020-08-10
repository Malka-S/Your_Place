using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class UsersDto
    {
        public int user_id { get; set; }
        public string user_last_name { get; set; }
        public string user_first_name { get; set; }
        public string user_phone_number { get; set; }
        public string user_email { get; set; }
        public string user_password { get; set; }
    }
}
