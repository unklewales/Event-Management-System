using Event_Management_System.Data;
using Event_Management_System.Models;
using Event_Management_System.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Event_Management_System.Controllers
{
    [Route("api/v1/EventManagementSystem")]
    [ApiController]
    public class Event_Management_SystemController : ControllerBase
    {
        private EventMgtSysDBContext context;
        public Event_Management_SystemController(EventMgtSysDBContext dBContext)
        {
            context = dBContext;
        }

        [HttpPost]
        [Route("event/add")]
        public IActionResult AddEvent(EventView model)
        {

            var eventModel = new EventModel
            {
                EventName = model.EventName,
                Location = model.Location,
                Description = model.Description,
                DateOfEvent = model.DateOfEvent,    
                
            };
            context.Events.Add(eventModel);
            context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("event")]
        public IActionResult GetAllEvent()
        {
            var events = context.Events.ToList();
            if (events.Count > 0)
            {
                return Ok(events);
            }
            return Ok("No records!");
        }

        [HttpGet]
        [Route("event/{id}")]
        public IActionResult GetEvent(int id)
        {
            var individualEvent = context.Events.Where(x => x.Id == id).FirstOrDefault();
            if (individualEvent != null)
            {
                return Ok(individualEvent);
            }
            return Ok("Record not found!");
        }

        [HttpPost]
        [Route("registrations/add")]
        public IActionResult AddRegistration(RegistrationView model)
        {
            var registeredUser = new Registration
            {
                UserName = model.UserName,
                Email = model.Email,
                EventID = model.EventID,
            };

            context.Registrations.Add(registeredUser);
            context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("registrations/{id}")]
        public IActionResult GetRegisteredUserDetails(int id)
        {
            var registeredUser = context.Registrations.Where(x => x.Id == id).FirstOrDefault();
            if (registeredUser != null)
            {
                return Ok(registeredUser);
            }
            return Ok("Record not found!");
        }
    }
}