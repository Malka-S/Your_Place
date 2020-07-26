using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class EventDal
    {
        public static List<Event> SelectEvents()
        {
            using (YourPlaceEntities1 db = new YourPlaceEntities1())
            {
                return db.Event.ToList();
            }
        }
    public static Event SalectEvent(int code)
    {
      using (YourPlaceEntities1 db = new YourPlaceEntities1())
      {
        return db.Event.FirstOrDefault(e => e.event_id == code);
      }
    }

    //public static int UpdateEvent(Event event)
    //{
    //    try
    //    {
    //        using (YourPlaceEntities1 db = new YourPlaceEntities1())
    //        {
    //            var q1=db.Event.FirstOrDefault(e => e.event_code==event.event_code);
    //            if (q1 == null)
    //                return 0;
    //            else
    //            {
    //                //עדכן
    //                ////ctx.Workers.Attach(worker);
    //                // ctx.Entry(worker).State = EntityState.Modified;

    //                q1.event_code = event.event_code;

    //                //שמור שינוי
    //                return db.SaveChanges();

    //            }
    //        }
    //    }
    //    catch
    //    {
    //        throw;
    //    }
    //}
    public static int DeletEvent(int code)
    {
      try
      {
        using (YourPlaceEntities1 db = new YourPlaceEntities1())
        {
          var q1 = db.Event.FirstOrDefault(e => e.event_id == code);
          if (q1 == null)
            return 0;
          else
          {
            //מחק
            db.Event.Remove(q1);
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

    // public static int AddEvent(Event event)
    // {
    //     try
    //     {
    //         using (YourPlaceEntities1 db = new YourPlaceEntities1())
    //         {
    //             var q1 = db.Event.Add(event);
    //             //שמור שינוי
    //             db.SaveChanges();
    //             return 1;//יתכן שנשקול להוסיף את המספור האוטמטי החדש 

    //         }
    //     }
    //     catch
    //     {
    //         throw;
    //     }
    // }

  }
}
