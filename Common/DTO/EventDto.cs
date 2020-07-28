using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class EventDto
    {
    public int event_id { get; set; }
    public Nullable<int> event_type_id { get; set; }
    public string event_des { get; set; }
    public System.DateTime event_date { get; set; }
    public Nullable<int> user_id { get; set; }
    public string invitation_file { get; set; }
    public System.DateTime due_date { get; set; }
  }
}
