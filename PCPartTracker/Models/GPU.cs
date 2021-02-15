using System;
using System.ComponentModel.DataAnnotations;

namespace PCPartTracker.Models
{
    public class GPU : IComponent
    {
        [Key]
        public int PCID { get; set; }
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
