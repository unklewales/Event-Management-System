using System.ComponentModel.DataAnnotations.Schema;

namespace Event_Management_System.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string DateOfEvent { get; set; }  
        public string Location { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        
        public IList<Registration> Registrations { get; set; }
        
    }
}
