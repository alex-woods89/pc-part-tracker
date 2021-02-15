using System;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class PCRepository : IPCRepositiory
    {
        public PC getPC()
        {
            PSU psu = new PSU("PSU", 450);
            GPU gpu = new GPU("Nvidia", 6, 2);
            CPU cpu = new CPU("Intel", 4, "4.5Ghz");
            Motherboard motherboard = new Motherboard("Alienware", FormFactor.ATX.ToString());
            Harddrive harddrive = new Harddrive("Sandisk", "1TB");
            RAM ram = new RAM("Sandisk", "8GB", 4);
            Case _case = new Case("Corsair", FormFactor.ATX.ToString());
            PC pc1 = new PC();

            pc1.PSU = psu;
            pc1.GPU = gpu;
            pc1.CPU = cpu;
            pc1.Motherboard = motherboard;
            pc1.Harddrive = harddrive;
            pc1.RAM = ram;
            pc1.Case = _case;
            return pc1;
        }

    }
}
