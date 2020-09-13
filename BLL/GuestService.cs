using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GuestService
    {
        public static int UpdateGuest(Common.DTO.GuestDto guest)
        {
            try
            {
                return DAL.GuestDal.UpdateGuest(Converters.GuestConverter.ToDalGuest(guest));
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public static int AddGuest(Common.DTO.GuestDto guest)
        {
            try
            {
                return DAL.GuestDal.AddGuest(Converters.GuestConverter.ToDalGuest(guest));
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
