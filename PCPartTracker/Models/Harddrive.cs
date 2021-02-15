using System;
using System.ComponentModel.DataAnnotations;

namespace PCPartTracker.Models
{
    public class Harddrive : IComponent
    {
        [Key]
        public int PCID { get; set; }
        public string Name { get; set; }

        public string Size { get; set; }

        public Harddrive(string name, string size)
        {
            Name = name;
            Size = size;
        }

    }
}
