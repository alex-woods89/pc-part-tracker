using System;
using System.ComponentModel.DataAnnotations;

namespace PCPartTracker.Models
{
    public class Motherboard : IComponent
    {
        [Key]
        public int PCID { get; set; }
        public string Name { get; set; }

        public string FormFactor { get; set; }

        public Motherboard(string name, string formFactor)
        {
            Name = name;
            FormFactor = formFactor;
        }

    }
}
