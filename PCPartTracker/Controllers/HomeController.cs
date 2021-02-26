using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using Microsoft.Extensions.Logging;
using PCPartTracker.Models;
using PCPartTracker.Repositories;
using PCPartTracker.ViewModels;
using SQLitePCL;

namespace PCPartTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPCRepositiory _pcRepo;
        private ICaseRepository _caseRepo;
        private ICPURepository _cpuRepo;
        private IGPURepository _gpuRepo;
        private IHarddriveRepository _harddriveRepo;
        private IMotherboardRepository _motherboardRepo;
        private IPSURepository _psuRepo;
        private IRAMRepository _ramRepo;

        public HomeController(ILogger<HomeController> logger, IPCRepositiory pcRepo, ICaseRepository caseRepo, ICPURepository cpuRepo, IGPURepository gpuRepo, IHarddriveRepository harddriveRepo, IMotherboardRepository motherboardRepo, IPSURepository psuRepo, IRAMRepository ramRepo)
        {
            _logger = logger;
            _pcRepo = pcRepo;
            _caseRepo = caseRepo;
            _cpuRepo = cpuRepo;
            _gpuRepo = gpuRepo;
            _harddriveRepo = harddriveRepo;
            _motherboardRepo = motherboardRepo;
            _psuRepo = psuRepo;
            _ramRepo = ramRepo;
        }

        public IActionResult Index()
        {
            PCViewModel pcs = new PCViewModel();
            pcs.PCs = _pcRepo.getPCs().ToList();
            pcs.Cases = _caseRepo.getCases().ToList();
            pcs.CPUs = _cpuRepo.getCPUs().ToList();
            pcs.GPUs = _gpuRepo.getGPUS().ToList();
            pcs.Harddrives = _harddriveRepo.getHarddrives().ToList();
            pcs.Motherboards = _motherboardRepo.getMotherboards().ToList();
            pcs.PSUs = _psuRepo.getPSUs().ToList();
            pcs.RAMs = _ramRepo.getRAMs().ToList();
            return View(pcs);
        }

        public IActionResult Create()
        {
            //ViewData["Cases"] = _caseRepo.getCases().ToList();
            //ViewData["CPUs"] = _cpuRepo.getCPUs().ToList();
            //ViewData["GPUs"] = _gpuRepo.getGPUS().ToList();
            //ViewData["Harddrives"] = _harddriveRepo.getHarddrives().ToList();
            //ViewData["Motherboards"] = _motherboardRepo.getMotherboards().ToList();
            //ViewData["PSUs"] = _psuRepo.getPSUs().ToList();
            //ViewData["RAMs"] = _ramRepo.getRAMs().ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(PC pc)
        {
            _pcRepo.savePC(pc);
            return RedirectToAction("Index");
        }

        public IActionResult Details(PC pc)
        {
            PC foundPC = _pcRepo.findPC(pc.ID);

            foundPC.CPU = _cpuRepo.findCPU(pc.ID);
            foundPC.GPU = _gpuRepo.findGPU(pc.ID);
            foundPC.Harddrive = _harddriveRepo.findHarddrive(pc.ID);
            foundPC.Motherboard = _motherboardRepo.findMotherboard(pc.ID);
            foundPC.PSU = _psuRepo.findPSU(pc.ID);
            foundPC.RAM = _ramRepo.findRam(pc.ID);
            foundPC.Case = _caseRepo.findCase(pc.ID);

            return View(foundPC);
        }


        public IActionResult Edit(int id)
        {
            PC pc = _pcRepo.findPC(id);
            return View(pc);
        }

        [HttpPost]
        public IActionResult Edit(PC pc)
        {
            _pcRepo.updatePC(pc);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(PC pc)
        {
            _pcRepo.deletePC(pc);
            return RedirectToAction("Index");

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
