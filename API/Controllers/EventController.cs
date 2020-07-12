using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class EventController : ApiController
    {
        public IHttpActionResult GetEvent()
        {
            try
            {
                var q = BLL.EventService.GetAllEvents();
                if(q!= null)
                    return Ok(q);
                return NotFound();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
