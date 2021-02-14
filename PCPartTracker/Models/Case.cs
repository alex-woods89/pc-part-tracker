using System;
namespace PCPartTracker.Models
{
    public class Case : IComponent
    {

        public string Name { get; set; }

        public FormFactor FormFactor { get; set; }

        public Case(string name, FormFactor formFactor)
        {
            Name = name;
            FormFactor = FormFactor;
        }
    }
}
