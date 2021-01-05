using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    //הגדרה אחת לתחילת הנתיב
    [RoutePrefix("api/CP")]
    public class ConfirmParticipationController : ApiController
    {
        [HttpGet]
        [Route("PostUser")]
        public IHttpActionResult PostCP(Common.DTO.ConfirmParticipationDto Cp)
        {
            try
            {
                int x = BLL.ConfirmParticipationService.UpdateConfirmParticipation(Cp);

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
        public IHttpActionResult PutCP(Common.DTO.ConfirmParticipationDto cp)
        {
            try
            {
                int x = BLL.ConfirmParticipationService.AddConfirmParticipation(cp);

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
