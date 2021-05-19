using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data.Entities
{
    public class TicketHistory
    {
        public int Id { get; set; }
        public Ticket Ticket { get; set; }
        public string PropertyChanged { get; set; }
        public string OldValueString { get; set; }
        public string NewValueString { get; set; }
        public DateTime DateChanged { get; set; }
        public User ChangedByUser { get; set; }
    }
}
