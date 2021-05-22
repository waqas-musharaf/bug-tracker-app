using BugTracker.Data;
using BugTracker.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TicketsController : Controller
    {
        private readonly IBugTrackerRepository _repository;
        private readonly ILogger<TicketsController> _logger;

        public TicketsController(IBugTrackerRepository repository, ILogger<TicketsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> Get()
        {
            try
            {
                return Ok(_repository.GetAllTickets());
            }
            catch (Exception e)
            {
                _logger.LogError($"Failed to get tickets: {e}");
                return BadRequest("Failed to get tickets");
            }
        }
    }
}
