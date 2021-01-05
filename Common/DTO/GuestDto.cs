﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
   public class GuestDto
    {

        public int guest_id { get; set; }
        public string guest_first_name { get; set; }
        public string guest_last_name { get; set; }
        public string guest_tz { get; set; }
        public string guest_email { get; set; }
        public Nullable<int> event_id { get; set; }
        public string gender { get; set; }
        public Nullable<int> table_id { get; set; }
        public string guest_message_befor { get; set; }
        public string guest_message_after { get; set; }
        public Nullable<int> guest_catagory_id { get; set; }
    }
}
