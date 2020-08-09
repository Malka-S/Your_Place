using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/user
        //[RoutePrefix("api/user")]

        public IHttpActionResult PostUser(Common.DTO.UserDto user)
        {
            try
            {
                int x = BLL.UsersService.UpdateUsers(user);

                if (x == 0)
                    return NotFound();
                else
                    return Ok(x);
            }
            catch (Exception e)
            {
                //שקרא לה תפס אותה וגם הוא זרק אותהbll היא נזרקה ואז הdal במקרה שגיאה ב
                //תפס את השגיאה והוא מעביר את טקסט השגיאה ללקוחbll שהפעיל את הwebapi ה
                //האנגולר יוכל לראות שחזר שגיאה ומה הייתה השגיאה 
                return BadRequest(e.Message);
            }

        }
    }
}
