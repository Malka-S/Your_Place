using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class EventDto
    {
        public int event_code { get; set; }
        public Nullable<int> event_type { get; set; }
        public string event_dis { get; set; }
        public System.DateTime event_date { get; set; }
        public Nullable<int> manager_code { get; set; }
        public Nullable<int> seating_arrangement_code { get; set; }
        public string invitation { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }

    }
}
