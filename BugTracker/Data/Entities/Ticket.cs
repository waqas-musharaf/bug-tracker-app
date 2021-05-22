using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SubmittedByUserId { get; set; }
        public int AssignedToUserId { get; set; }
        public int ProjectId { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }
        public string Comments { get; set; }
        public ICollection<TicketHistory> History { get; set; }

        public Project Project { get; set; }
    }
}
