namespace StudentRecords.API.Models
{
    public class Modules
    {
        public int ModulesId { get; set; }

        public string ModulesName { get; set; } = string.Empty;

        public GradeEnum Grade { get; set; } = GradeEnum.F;

    }
}