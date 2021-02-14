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
            Motherboard motherboard = new Motherboard("Alienware", FormFactor.ATX);
            Harddrive harddrive = new Harddrive("Sandisk", "1TB");
            RAM ram = new RAM("Sandisk", "8GB", 4);
            Case _case = new Case("Corsair", FormFactor.ATX);
            PC pc = new PC(gpu, psu, motherboard, cpu, harddrive, ram, _case);

            return pc;
        }

    }
}
