﻿using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRecords.API.Models
{
    public class Degree
    {
        public int DegreeId { get; set; }
        public string DegreeName { get; set; } = null!;
        public string DegreeDescription { get; set; } = null!;
        public ICollection<Module>? Modules { get; set; }

    }
}