using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace PCPartTracker.Models
{
    public class PC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public GPU GPU { get; set; }
        public PSU PSU { get; set; }
        public Motherboard Motherboard { get; set; }
        public CPU CPU { get; set; }
        public Harddrive Harddrive { get; set; }
        public RAM RAM { get; set; }
        public Case Case { get; set; }
    }
}
