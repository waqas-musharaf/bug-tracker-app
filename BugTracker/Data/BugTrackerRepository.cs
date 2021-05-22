using BugTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class BugTrackerRepository : IBugTrackerRepository
    {
        private readonly BugTrackerContext _context;
        private readonly ILogger<BugTrackerRepository> _logger;

        public BugTrackerRepository(BugTrackerContext context, ILogger<BugTrackerRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            try
            {
                return _context.Projects
                    .Include(p => p.AttachedTickets)
                    .OrderBy(p => p.Id)
                    .ToList();

            }
            catch (Exception e)
            {
                _logger.LogError($"GetAllProjects failed: {e}");
                return null;
            }
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            try
            {
                return _context.Tickets
                    .OrderBy(t => t.Id)
                    .ToList();
            }
            catch (Exception e)
            {
                _logger.LogError($"GetAllTickets failed: {e}");
                return null;
            }
        }

        public Project GetProjectById(int id)
        {
            try
            {
                return _context.Projects
                    .Include(p => p.AttachedTickets)
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

            }
            catch (Exception e)
            {
                _logger.LogError($"GetProjectById failed: {e}");
                return null;
            }
        }

        public IEnumerable<Project> GetProjectsByName(string name)
        {
            try
            {
                return _context.Projects
                    .Where(p => p.Name.ToLowerInvariant().Contains(name.ToLowerInvariant()))
                    .ToList();
            }
            catch (Exception e)
            {
                _logger.LogError($"GetProjectsByName failed: {e}");
                return null;
            }
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
