using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTO;
using DAL;
namespace Converters
{
  public class EventConverter
  {
    public static Event ToDalEvent(EventDto e)
    {
      Event ev = new Event();
      ev.event_id = e.event_id;
      ev.invitation_file = e.invitation_file;
      ///....
      return ev;
    }
    public static EventDto ToDtoEvent(Event e)
    {
      EventDto ev = new EventDto();
      ev.event_id = e.event_id;
      ev.invitation_file = e.invitation_file;
      return ev;

    }
    public static List<Event> ToDalEventList(List<EventDto> l)
    {
      List<Event> le = new List<Event>();
      foreach (var item in l)
      {
        le.Add(ToDalEvent(item));

      }
      return le;
    }

    public static List<EventDto> ToDtoEventList(List<Event> l)
    {
      List<EventDto> le = new List<EventDto>();
      foreach (var item in l)
      {
        le.Add(ToDtoEvent(item));

      }
      return le;
    }
    //public static List<BaseCodeDto> ToDtoEventTypeList(List<EventType> l)
    //{
    //  List<BaseCodeDto> le = new List<BaseCodeDto>();
    //  foreach (var item in l)
    //  {
    //    le.Add(ToDtoBaseCode(item.event_type_id, item.event_type_des));

    //  }
    //  return le;
    //}
    public static List<BaseCodeDto> ToDtoEventTypeList()
    {
      
      List<BaseCodeDto> le = new List<BaseCodeDto>();
      le.Add(ToDtoBaseCode(1, "חתונה"));
      le.Add(ToDtoBaseCode(2, "בר מצווה"));
      le.Add(ToDtoBaseCode(3, "ארוסין"));
      le.Add(ToDtoBaseCode(4, "בת מצווה"));
      le.Add(ToDtoBaseCode(5, "ברית"));
    
      return le;
    }

    public static BaseCodeDto ToDtoBaseCode(int id, string des)
    {
      BaseCodeDto bc = new BaseCodeDto();
      bc.Id = id;
      bc.Des = des;
      return bc;
    }
  }
}
