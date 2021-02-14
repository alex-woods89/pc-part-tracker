using System;
namespace PCPartTracker.Models
{
    public class GPU : IComponent
    {
        public string Name { get; set; }

        public int Cores { get; set; }

        public int NumberOfOutputs { get; set; }

        public GPU(string name, int cores, int numberOfOutputs)
        {
            Name = name;
            Cores = cores;
            NumberOfOutputs = numberOfOutputs;
        }
    }
}
