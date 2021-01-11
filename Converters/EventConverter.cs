using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Converters
{
  public class EventConverter
  {
    public static DAL.Event ToDalEvent(Common.DTO.EventDto e)
    {
      DAL.Event ev = new DAL.Event();
      ev.event_id = e.event_id;
      ev.invitation_file = e.invitation_file;
      ///....
      return ev;
    }
    public static Common.DTO.EventDto ToDtoEvent(DAL.Event e)
    {
      Common.DTO.EventDto ev = new Common.DTO.EventDto();
      ev.event_id = e.event_id;
      ev.invitation_file = e.invitation_file;
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

    public static object ToDalInvitation(FileWebRequest file)
    {
      throw new NotImplementedException();
    }

    //public static List<Common.DTO.BaseCodeDto> ToDtoEventTypeList(List<DAL.EventType> l)
    //{
    //  List<Common.DTO.BaseCodeDto> le = new List<Common.DTO.BaseCodeDto>();
    //  foreach (var item in l)
    //  {
    //    le.Add(ToDtoBaseCode(item.event_type_id, item.event_type_des));

    //  }
    //  return le;
    //}
    public static List<Common.DTO.BaseCodeDto> ToDtoEventTypeList()
    {

      List<Common.DTO.BaseCodeDto> le = new List<Common.DTO.BaseCodeDto>();
      le.Add(ToDtoBaseCode(1, "חתונה"));
      le.Add(ToDtoBaseCode(2, "בר מצווה"));
      le.Add(ToDtoBaseCode(3, "ארוסין"));
      le.Add(ToDtoBaseCode(4, "בת מצווה"));
      le.Add(ToDtoBaseCode(5, "ברית"));

      return le;
    }

    public static Common.DTO.BaseCodeDto ToDtoBaseCode(int id, string des)
    {
      Common.DTO.BaseCodeDto bc = new Common.DTO.BaseCodeDto();
      bc.Id = id;
      bc.Des = des;
      return bc;
    }
  }
}
