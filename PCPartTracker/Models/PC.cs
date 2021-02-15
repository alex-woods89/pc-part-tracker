using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCPartTracker.Models
{
    public class PC
    {
        public int ID { get; set; }

        public GPU GPU { get; set; }

        public PSU PSU { get; set; }

        public Motherboard Motherboard { get; set; }

        public CPU CPU { get; set; }

        public Harddrive Harddrive { get; set; }

        public RAM RAM { get; set; }

        public Case Case { get; set; }


        //    public PC(int gpu, int psu, int motherboard, int cpu, int harddrive, int ram, int _case)
        //    {
        //        GpuID = gpu;
        //        PsuID = psu;
        //        MotherboardID = motherboard;
        //        CpuID = cpu;
        //        HarddriveID = harddrive;
        //        RamID = ram;
        //        CaseID = _case;
        //    }
    }
}
