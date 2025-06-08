namespace ApiSinhVien.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Uid { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }
}
