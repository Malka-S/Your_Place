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
    }

}
