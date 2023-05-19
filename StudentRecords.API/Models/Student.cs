namespace StudentRecords.API.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public Degree Degree { get; set; } = null!;
        public Module Module { get; set; } = null!;
    }
}
