namespace ChillToeic.Models
{
    public class Course
    {
    public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Level { get; set; }
        public int QuantityLecture { get; set; }
        public int QuantityRegister { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int EducationCenterId { get; set; }
        public bool IsApprove { get; set; }
    }
}
