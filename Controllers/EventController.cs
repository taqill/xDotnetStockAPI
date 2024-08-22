using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
    }

    private static readonly List<Event> Events = new List<Event>
    {
            new Event { Id = 1, Title = "Meeting Team A", Start = new DateTime(2024, 8, 10, 9, 0, 0), End = new DateTime(2024, 8, 12, 17, 0, 0) },
            new Event { Id = 2, Title = "Sale Team Report", Start = new DateTime(2024, 8, 15, 10, 30, 0), End = new DateTime(2024, 8, 16, 14, 0, 0) },
            new Event { Id = 3, Title = "ประชุมทีม DevOpt", Start = new DateTime(2024, 8, 20, 8, 0, 0) },
            new Event { Id = 3, Title = "ส่งต้นแบบงาน MOPA", Start = new DateTime(2024, 8, 24, 14, 30, 0) },
            new Event { Id = 3, Title = "จัดเลี้ยงทีมงาน", Start = new DateTime(2024, 8, 26, 19, 0, 0) }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Event>> GetEvents()
    {
        return Ok(Events);
    }

}