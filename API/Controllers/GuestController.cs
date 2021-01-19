using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.DTO;
using BLL;

namespace API.Controllers
{
  [System.Web.Http.RoutePrefix("api/Guest")]

  public class GuestController : ApiController
  {

    public IHttpActionResult GetGuestList()
    {
      try
      {
        var q = GuestService.GetAllGuests();
        if (q != null)
          return Ok(q);
        return NotFound();
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    public IHttpActionResult GetGuestsByCategory(string category)
    {
      try
      {
        var q = GuestService.GetGuestListByCategory(category);
        if (q != null)
          return Ok(q);
        return NotFound();
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //add
    public IHttpActionResult PutGuest(GuestDto guest)
    {
      try
      {
        var q = GuestService.AddGuest(guest);
        //if (q == null)
        //  return NotFound();
        return Ok(q);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //update
    public IHttpActionResult PostGuest(GuestDto guest)
    {
      try
      {
        int x = GuestService.UpdateGuest(guest);

        if (x == 0)
          return NotFound();
        else
          return Ok(x);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //אולי כדאי לפתוח קונטרולר נפרד
    public IHttpActionResult SendMail(string a, string b)
    {
      try
      {
        PlacementService.sendmail(a, b);
        return Ok();
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
