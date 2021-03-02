using System;
using System.ComponentModel.DataAnnotations;

namespace PCPartTracker.Models
{
    public class Case : IComponent
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string FormFactor { get; set; }

        public Case(string name, string formFactor)
        {
            Name = name;
            FormFactor = formFactor;
        }
    }
}
