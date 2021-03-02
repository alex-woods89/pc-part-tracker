using PCPartTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PCPartTracker.Data
{
    public class DbSeedData
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            PC pc1 = new PC();
            PSU psu = new PSU("PSU", 450);
            psu.PCID = pc1.ID;
            GPU gpu = new GPU("Nvidia", 6, 2);
            gpu.PCID = pc1.ID;
            CPU cpu = new CPU("Intel", 4, "4.5Ghz");
            cpu.PCID = pc1.ID;
            Motherboard motherboard = new Motherboard("Alienware", FormFactor.ATX.ToString());
            motherboard.PCID = pc1.ID;
            Harddrive harddrive = new Harddrive("Sandisk", "1TB");
            harddrive.PCID = pc1.ID;
            RAM ram = new RAM("Sandisk", "8GB", 4);
            ram.PCID = pc1.ID;
            Case _case = new Case("Alienware", FormFactor.ATX.ToString());
            //_case.PCID = pc1.ID;

            pc1.Name = "PC 1";
            pc1.PSU = psu;
            pc1.GPU = gpu;
            pc1.CPU = cpu;
            pc1.Motherboard = motherboard;
            pc1.Harddrive = harddrive;
            pc1.RAM = ram;
            pc1.Case = _case;

            context.PSUs.Add(psu);
            context.GPUs.Add(gpu);
            context.CPUs.Add(cpu);
            context.Motherboards.Add(motherboard);
            context.Harddrives.Add(harddrive);
            context.RAMs.Add(ram);
            context.Cases.Add(_case);
            context.PCs.Add(pc1);

            PC pc2 = new PC();
            PSU psu1 = new PSU("PSU", 450);
            psu1.PCID = pc2.ID;
            GPU gpu1 = new GPU("Nvidia", 6, 2);
            gpu1.PCID = pc2.ID;
            CPU cpu1 = new CPU("Intel", 4, "4.5Ghz");
            cpu1.PCID = pc2.ID;
            Motherboard motherboard1 = new Motherboard("Alienware", FormFactor.MiniATX.ToString());
            motherboard1.PCID = pc2.ID;
            Harddrive harddrive1 = new Harddrive("Sandisk", "1TB");
            harddrive1.PCID = pc2.ID;
            RAM ram1 = new RAM("Sandisk", "8GB", 4);
            ram1.PCID = pc2.ID;
            Case _case1 = new Case("Corsair", FormFactor.MiniATX.ToString());
            //_case1.PCID = pc2.ID;


            pc2.Name = "PC 2";
            pc2.PSU = psu1;
            pc2.GPU = gpu1;
            pc2.CPU = cpu1;
            pc2.Motherboard = motherboard1;
            pc2.Harddrive = harddrive1;
            pc2.RAM = ram1;
            pc2.Case = _case1;

            context.PSUs.Add(psu1);
            context.GPUs.Add(gpu1);
            context.CPUs.Add(cpu1);
            context.Motherboards.Add(motherboard1);
            context.Harddrives.Add(harddrive1);
            context.RAMs.Add(ram1);
            context.Cases.Add(_case1);
            context.PCs.Add(pc2);

            context.SaveChanges();
        }
    }
}
