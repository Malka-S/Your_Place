using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class GuestDal
  {
    public static int AddGuest(Guest guest)
    {
      try
      {
        using (YourPlaceEntities db = new YourPlaceEntities())
        {
          var q1 = db.Guest.Add(guest);
          //שמור שינוי
          db.SaveChanges();
          return 1;//יתכן שנשקול להוסיף את המספור האוטמטי החדש 
        }
      }
      catch
      {
        throw;
      }
    }
    public static int UpdateGuest(Guest guest)
    {
      //אמור להיות update
      try
      {
        using (YourPlaceEntities db = new YourPlaceEntities())
        {
          var q1 = db.Guest.FirstOrDefault(g=>g.guest_id==guest.guest_id);
          //שמור שינוי
          db.SaveChanges();
          return 1;//יתכן שנשקול להוסיף את המספור האוטמטי החדש 
        }
      }
      catch
      {
        throw;
      }
    }
    public static List<Guest> SelectGuestsByCatagory(string category)
    {

      using (YourPlaceEntities db = new YourPlaceEntities())
      {
        return db.Guest.Where(e => e.Guest_catagory.guest_catagory_des == category).ToList();
      }
    }
    public static List<Guest> SelectGuests()
    {
      using (YourPlaceEntities db = new YourPlaceEntities())
      {
        //לא נראה לי צריך שורות אלו
        //Context.Connection.Open();
        //Content.Connection.Open();
        return db.Guest.ToList();
      }
    }

    public static int DeleteGuest(Guest guest)
    {
      try
      {
        using (YourPlaceEntities db = new YourPlaceEntities())
        {
          //אמור למחוק את האורח שקיבל 
          var q1 = db.Guest.FirstOrDefault();
          if (q1 == null)
            return 0;
          else
          {
            //מחק
            db.Guest.Remove(q1);
            //שמור שינוי
            db.SaveChanges();
            //החזר 1
            return 1;
          }
        }
      }
      catch
      {
        throw;
      }

    }
  }
}
