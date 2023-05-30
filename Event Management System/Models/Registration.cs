namespace Event_Management_System.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int EventModelId { get; set; }
       //public EventModel EventModel { get; set; }
       //public IList<EventModel> Events { get; set; }
        
    }
}
