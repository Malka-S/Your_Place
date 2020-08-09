using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class UsersDal
    {
        public static int UpdateUsers(Users users)
        {
            try
            {
                using (YourPlaceEntities db = new YourPlaceEntities())
                {
                    var q1 = db.Users.FirstOrDefault(e => e.user_email == users.user_email);
                    if (q1 == null)
                        return 0;
                    else
                    {
                        //עדכן
                        //ctx.Users.Attach(users);
                        // ctx.Entry(users).State = EntityState.Modified;

                        q1.user_email = users.user_email;
                        q1.user_first_name = users.user_first_name;
                        q1.user_id = users.user_id;
                        q1.user_last_name = users.user_last_name;
                        q1.user_password = users.user_password;
                        q1.user_phone_number = users.user_phone_number;

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
    }
}

    

