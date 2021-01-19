using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTO;
using DAL;
namespace BLL
{
    public class EventService
    {
       public static List<EventDto> GetAllEvents()
        {
            return Converters.EventConverter.ToDtoEventList(EventDal.SelectEvents());
            
        }
    //public static List<Common.DTO.BaseCodeDto> GetEventType()
    //{
    //  return Converters.EventConverter.ToDtoEventTypeList(EventDal.SelectEventType());
    //}
    public static List<BaseCodeDto> GetEventType()
    {
      return Converters.EventConverter.ToDtoEventTypeList();
    }
    public static EventDto SelectEvents(int code)
    {
      return Converters.EventConverter.ToDtoEvent(EventDal.SalectEvent(code));
    }

    public static int DeleteEventByCode(int code)
    {
      try
      {
        return DAL.EventDal.DeleteEvent(code);
      }
      catch
      {
        throw;
      }
    }

    //public static int UpdateEvent(Common.DTO.EventDto event)
    //{
    //    try
    //    {
    //        return DAL.EventDal.UpdateEvent(Converters.EventConverter.ToDalEvent(event));
    //    }
    //    catch (Exception e)
    //    {

    //        throw;
    //    }
    //}

    //public static int AddEvent(Common.DTO.EventDto event)
    //{
    //    try
    //    {
    //        return DAL.EventDal.AddEvent(Converters.EventConverter.ToDalEvent(event));
    //    }
    //    catch (Exception e)
    //    {

    //        throw;
    //    }
    //}
  }

}
