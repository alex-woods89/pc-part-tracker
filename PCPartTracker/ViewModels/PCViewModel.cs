using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.ViewModels
{
    public class PCViewModel
    {
        public List<PC> PCs { get; set; }
        public List<Case> Cases { get; set; }
        public List<CPU> CPUs { get; set; }
        public List<GPU> GPUs { get; set; }
        public List<Harddrive> Harddrives { get; set; }
        public List<Motherboard> Motherboards { get; set; }
        public List<PSU> PSUs { get; set; }
        public List<RAM> RAMs { get; set; }
    }
}
