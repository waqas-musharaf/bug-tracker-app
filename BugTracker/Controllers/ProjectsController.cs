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
    public class ProjectsController : Controller
    {
        private readonly IBugTrackerRepository _repository;
        private readonly ILogger<ProjectsController> _logger;

        public ProjectsController(IBugTrackerRepository repository, ILogger<ProjectsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Project>> Get()
        {
            try
            {
                return Ok(_repository.GetAllProjects());
            }
            catch (Exception e)
            {
                _logger.LogError($"Failed to get products: {e}");
                return BadRequest("Failed to get products");
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<Project> Get(int id)
        {
            try
            {
                var project = _repository.GetProjectById(id);

                if (project != null) return Ok(project);
                else return NotFound();
            }
            catch (Exception e)
            {
                _logger.LogError($"Failed to get products: {e}");
                return BadRequest("Failed to get products");
            }
        }
    }
}
