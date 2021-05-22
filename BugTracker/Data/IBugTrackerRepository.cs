using BugTracker.Data.Entities;
using System.Collections.Generic;

namespace BugTracker.Data
{
    public interface IBugTrackerRepository
    {
        IEnumerable<Project> GetAllProjects();
        IEnumerable<Project> GetProjectsByName(string name);
        Project GetProjectById(int id);

        IEnumerable<Ticket> GetAllTickets();

        bool SaveAll();
    }
}