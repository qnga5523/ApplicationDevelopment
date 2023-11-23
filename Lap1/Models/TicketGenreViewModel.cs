using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lap1.Models
{
    public class TicketGenreViewModel
    {
        public List<Ticket> TicketList { get; set; }
        public SelectList? Genre {  get; set; }
        public string? TicketGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
