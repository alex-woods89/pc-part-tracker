using System;
using System.ComponentModel.DataAnnotations;

namespace PCPartTracker.Models
{
    public class PSU : IComponent
    {
        [Key]
        public int PCID { get; set; }
        public string Name { get; set; }

        public int Watts { get; set; }

        public PSU(string name, int watts)
        {
            Name = name;
            Watts = watts;
        }

        
    }
}
