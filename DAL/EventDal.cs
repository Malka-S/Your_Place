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
            using (YourPlaceEntities db = new YourPlaceEntities())
            {
                return db.Event.ToList();
            }
        }
    }
}
