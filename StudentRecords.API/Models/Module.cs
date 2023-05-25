using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StudentRecords.API.Models
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public string ModuleName { get; set; } = string.Empty;
        public GradeEnum ModuleGrade { get; set; } = GradeEnum.F;

        [ForeignKey("DegreeId")]
        public int DegreeId { get; set; }
        public Degree? Degree { get; set; }
    }
}