using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converters
{
    public class EventConverter
    {
        public static DAL.Event ToDalEvent(Common.DTO.EventDto e)
        {
            DAL.Event ev = new DAL.Event();
            ev.event_code = e.event_code;
            ev.invitation = e.invitation;
            ///....
            return ev;
        }
        public static Common.DTO.EventDto ToDtoEvent( DAL.Event e)
        {
            Common.DTO.EventDto ev = new Common.DTO.EventDto();
            ev.event_code = e.event_code;
            ev.invitation = e.invitation;
            return ev;

        }
        public static List<DAL.Event> ToDalEventList(List<Common.DTO.EventDto> l)
        {
            List<DAL.Event> le = new List<DAL.Event>();
            foreach (var item in l)
            {
                le.Add(ToDalEvent(item));

            }
            return le;
        }

        public static List<Common.DTO.EventDto> ToDtoEventList(List<DAL.Event> l)
        {
            List<Common.DTO.EventDto> le = new List<Common.DTO.EventDto>();
            foreach (var item in l)
            {
                le.Add(ToDtoEvent(item));

            }
            return le;
        }


    }
}
