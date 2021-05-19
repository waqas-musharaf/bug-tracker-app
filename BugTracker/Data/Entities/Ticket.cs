using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User SubmittedBy { get; set; }
        public List<User> AssignedTo { get; set; }
        public Project OfProject { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }
        public string Comments { get; set; }
        public List<TicketHistory> History { get; set; }
    }
}
