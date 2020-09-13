using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GuestDal
    {

        public static int UpdateGuest(Guest guest)
        {
            try
            {
                using (YourPlaceEntities db = new YourPlaceEntities())
                {
                    var q1 = db.Guest.FirstOrDefault(e => e.guest_email == guest.guest_email);
                    if (q1 == null)
                        return 0;
                    else
                    {
                        //עדכן
                        //ctx.Users.Attach(users);
                        // ctx.Entry(users).State = EntityState.Modified;

                        q1.guest_email = guest.guest_email;
                        q1.guest_first_name = guest.guest_first_name;
                        q1.guest_id = guest.guest_id;
                        q1.guest_last_name = guest.guest_last_name;
                        q1.guest_message_after = guest.guest_message_after;
                        q1.guest_message_befor = guest.guest_message_befor;
                        q1.guest_tz = guest.guest_tz;
                        q1.gender = guest.gender;
                        q1.table_id = guest.table_id;
                        q1.guest_catagory_id = guest.guest_catagory_id;
                        //שמור שינוי
                        return db.SaveChanges();

                    }

                }
            }
            catch
            {
                throw;
            }
        }
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
    }
}
