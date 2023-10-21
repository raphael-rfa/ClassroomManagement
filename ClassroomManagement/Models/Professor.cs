namespace ClassroomManagement.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Subject? Subject { get; set; }
        public ProfessorSubject? ProfessorSubject { get; set; }
    }
}
