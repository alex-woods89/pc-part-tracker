using System;
using System.Collections.Generic;

namespace PCPartTracker.Models
{
    public class PC
    {
        public int Id { get; set; }

        public GPU Gpu { get; set; }

        public PSU Psu { get; set; }

        public Motherboard Motherboard { get; set; }

        public CPU Cpu { get; set; }

        public Harddrive Harddrive { get; set; }

        public RAM Ram { get; set; }

        public Case Case { get; set; }


        public PC(GPU gpu, PSU psu, Motherboard motherboard, CPU cpu, Harddrive harddrive, RAM ram, Case _case)
        {
            Gpu = gpu;
            Psu = psu;
            Motherboard = motherboard;
            Cpu = cpu;
            Harddrive = harddrive;
            Ram = ram;
            Case = _case;
        }
    }
}
