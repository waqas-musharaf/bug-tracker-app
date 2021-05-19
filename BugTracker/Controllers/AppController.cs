using BugTracker.Data;
using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    public class AppController : Controller
    {
        private readonly IBugTrackerRepository _repository;

        public AppController(IBugTrackerRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            var projects = _repository.GetAllProjects();

            return View(projects);
        }
    }
}
