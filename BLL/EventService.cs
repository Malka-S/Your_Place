using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.DTO;

namespace BLL
{
    public class EventService
    {
       public static List<Common.DTO.EventDto> GetAllEvents()
        {
            return Converters.EventConverter.ToDtoEventList (DAL.EventDal.SelectEvents());
        }

    public static List<Common.DTO.BaseCodeDto> GetEventType()
    {
      return Converters.EventConverter.ToDtoEventTypeList(DAL.EventDal.SelectEventType());
    }
    public static Common.DTO.EventDto SelectEvents(int code)
    {
      return Converters.EventConverter.ToDtoEvent(DAL.EventDal.SalectEvent(code));
    }

    public static int DeleteEventByCode(int code)
    {
      try
      {
        return DAL.EventDal.DeletEvent(code);
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
