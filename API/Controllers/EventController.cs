using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace API.Controllers

{
  //הגדרה אחת לתחילת הנתיב
  [System.Web.Http.RoutePrefix("api/Event")]
  public class EventController : ApiController
  {
    public IHttpActionResult GetEvent()
    {
      try
      {
        var q = BLL.EventService.GetAllEvents();
        if (q != null)
          return Ok(q);
        return NotFound();
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [RequireHttps]
    [System.Web.Http.HttpGet]
    [System.Web.Http.Route("GetEventType")]
    public IHttpActionResult GetEventType()
    {
      try
      {
        var q = BLL.EventService.GetEventType();
        if (q != null)
          return Ok(q);
        return NotFound();
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    //Rout עם פרמטרים
    //יש לכלול פרמטרים בהגדרת הנתיב
    [System.Web.Http.HttpGet]
    [System.Web.Http.Route("GetByCode")]
    public IHttpActionResult GetEventByCode(int code)
    {
      var q1 = BLL.EventService.SelectEvents(code);
      if (q1 == null)
        return NotFound();
      return Ok(q1);

    }
    //מחיקה
    //.../api/Event/1016
    public IHttpActionResult DeleteEventByCode(int code)
    {
      //מה אנחנו צריכות לעשות עכשיחו
      //1.bl שתקרא לפונקציה בwebapi  להוסיף פונקציה ב
      //2.dal שתקרא לפונקציה ב bl להוסיף פונקציה ב
      //3. Dal להוסיף פונקציה ב
      try
      {
        int x = BLL.EventService.DeleteEventByCode(code);

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

//    public IHttpActionResult PutEvent(Common.DTO.EventDto event)
//    {
//      try
//      {
//        int x = BLL.EventService.AddEvent(event);
//            if (x == 0)
//                return NotFound();
//            else
//                return Ok(x);
//  }
//        catch (Exception e)
//        {
//            //שקרא לה תפס אותה וגם הוא זרק אותהbll היא נזרקה ואז הdal במקרה שגיאה ב
//            //תפס את השגיאה והוא מעביר את טקסט השגיאה ללקוחbll שהפעיל את הwebapi ה
//            //האנגולר יוכל לראות שחזר שגיאה ומה הייתה השגיאה 
//            return BadRequest(e.Message);
//}
//    }

    //public IHttpActionResult PostEvent(Common.DTO.EventDto event)
    //{
    //    try
    //    {
    //        int x = BLL.EventService.UpdateEvent(event);

    //        if (x == 0)
    //            return NotFound();
    //        else
    //            return Ok(x);
    //    }
    //    catch (Exception e)
    //    {
    //        //שקרא לה תפס אותה וגם הוא זרק אותהbll היא נזרקה ואז הdal במקרה שגיאה ב
    //        //תפס את השגיאה והוא מעביר את טקסט השגיאה ללקוחbll שהפעיל את הwebapi ה
    //        //האנגולר יוכל לראות שחזר שגיאה ומה הייתה השגיאה 
    //        return BadRequest(e.Message);
    //    }

  }
}
