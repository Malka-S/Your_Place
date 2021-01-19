using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTO;
using DAL;
namespace Converters
{
  public class GuestConverter
  {
    public static Guest ToDalGuest(GuestDto g)
    {
      Guest gu = new Guest();
      gu.guest_id = g.guest_id;
      gu.guest_first_name = g.guest_first_name;
      gu.guest_last_name = g.guest_last_name;
      gu.guest_email = g.guest_email;
      //gu.guest_tz = g.guest_tz;
      ///....
      return gu;
    }
    public static GuestDto ToDtoGuest(Guest g)
    {
      GuestDto gu = new GuestDto();
      gu.guest_id = g.guest_id;
      gu.guest_first_name = g.guest_first_name;
      gu.guest_last_name = g.guest_last_name;
      gu.guest_email = g.guest_email;
     // gu.guest_tz = g.guest_tz;
      ///....
      return gu;

    }
    public static List<Guest> ToDalGuestList(List<GuestDto> l)
    {
      List<Guest> le = new List<Guest>();
      foreach (var item in l)
      {
        le.Add(ToDalGuest(item));
      }
      return le;
    }

    public static List<GuestDto> ToDtoGuestList(List<Guest> l)
    {
      List<GuestDto> le = new List<GuestDto>();
      foreach (var item in l)
      {
        le.Add(ToDtoGuest(item));
      }
      return le;
    }
  }
}
