namespace ClassroomManagement.Models.ViewModel
{
    public class StudentViewModel
    {
        public Student? Student { get; set; }
        public Exam? Exam { get; set; }

        public static implicit operator StudentViewModel?(Student? v)
        {
            StudentViewModel student;        
            student = new StudentViewModel { Student = v };
            return student;            
            throw new NotImplementedException();
        }

        public static implicit operator StudentViewModel?(Exam? p)
        {
            Student student = new Student { Id = p!.Student!.Id, Name = p.Student.Name};
            StudentViewModel exam;
            exam = new StudentViewModel { Exam = p, Student = student};
            exam.Exam.StudentId = p.Student.Id;
            return exam;
            throw new NotImplementedException();
        }
    }
}
