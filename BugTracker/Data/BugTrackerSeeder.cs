using BugTracker.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class BugTrackerSeeder
    {
        private readonly BugTrackerContext _context;
        private readonly IWebHostEnvironment _env;

        public BugTrackerSeeder(BugTrackerContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public void SeedProjects()
        {
            _context.Database.EnsureCreated();

            if (!_context.Projects.Any())
            {
                var filePath = Path.Combine(_env.ContentRootPath, "Data/ProjectExamples.json");
                var json = File.ReadAllText(filePath);
                var projects = JsonSerializer.Deserialize<IEnumerable<Project>>(json);

                _context.Projects.AddRange(projects);
                _context.SaveChanges();
            }
        }

        public void SeedTickets()
        {
            _context.Database.EnsureCreated();

            if (!_context.Tickets.Any())
            {
                var filePath = Path.Combine(_env.ContentRootPath, "Data/TicketExamples.json");
                var json = File.ReadAllText(filePath);
                var tickets = JsonSerializer.Deserialize<IEnumerable<Ticket>>(json);

                _context.Tickets.AddRange(tickets);
                _context.SaveChanges();
            }
        }
    }
}
