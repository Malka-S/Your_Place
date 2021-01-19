using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTO;
using DAL;
using Converters;


namespace BLL
{
  public class GuestService
  {
    public static List<GuestDto> GetAllGuests()
    {
      return
        GuestConverter.ToDtoGuestList(GuestDal.SelectGuests());
    }
    public static List<GuestDto> GetGuestListByCategory(string category)
    {
      return
        GuestConverter.ToDtoGuestList(GuestDal.SelectGuestsByCatagory(category));
    }
    public static int AddGuest(GuestDto guest)
    {
      try
      {
        return GuestDal.AddGuest(
          GuestConverter.ToDalGuest(guest));
      }
      catch (Exception e)
      {

        throw e;
      }
    }
    public static int UpdateGuest(GuestDto guest)
    {
      try
      {
        return GuestDal.UpdateGuest(
          GuestConverter.ToDalGuest(guest));
      }
      catch (Exception e)
      {

        throw e;
      }
    }
    public static int DeleteGuest(GuestDto guest)
    {
      try
      {
        return GuestDal.DeleteGuest(
          GuestConverter.ToDalGuest(guest));
      }
      catch (Exception e)
      {

        throw e;
      }
    }
  }
}
