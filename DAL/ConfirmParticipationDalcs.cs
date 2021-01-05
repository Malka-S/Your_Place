using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConfirmParticipationDalcs
    {
        public static int UpdateConfirmParticipation(guest_table_member gtm)
        {
            try
            {
                using (YourPlaceEntities db = new YourPlaceEntities())
                {
                    var q1 = db.guest_table_member.FirstOrDefault(e => e.guest_id == gtm.guest_id);
                    if (q1 == null)
                        return 0;
                    else
                    {
                        //עדכן
                        //ctx.Users.Attach(users);
                        // ctx.Entry(users).State = EntityState.Modified;

                        //q1.friend_id = gtm.friend_id;
                        //q1.like_or_not = gtm.like_or_not;
                        q1.table_members_id = gtm.table_members_id;

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
        public static int AddConfirmParticipation(guest_table_member gtm)
        {
            try
            {
                using (YourPlaceEntities db = new YourPlaceEntities())
                {
                    var q1 = db.guest_table_member.Add(gtm);
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
