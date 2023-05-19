using System.ComponentModel.DataAnnotations;

namespace StudentRecords.API.Models
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public string ModuleName { get; set; } = string.Empty;
        public GradeEnum ModuleGrade { get; set; } = GradeEnum.F;
        public int DegreeId { get; set; }
        public Degree? Degree { get; set; }
    }
}