using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PCPartTracker.Models;
using PCPartTracker.Repositories;

namespace PCPartTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPCRepositiory _pcRepo;

        public HomeController(ILogger<HomeController> logger, IPCRepositiory pcRepo)
        {
            _logger = logger;
            _pcRepo = pcRepo;

        }

        public IActionResult Index()
        {
            PC pc = _pcRepo.getPC();
            _logger.LogInformation("Passing PC to The View");
            return View(pc);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
