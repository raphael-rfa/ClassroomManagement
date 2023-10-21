namespace ClassroomManagement.Models.ViewModel
{
    public class ProfessorExam
    {

        public Professor? Professor { get; set; }
        public Subject? Subject { get; set; }
        public Student? Student { get; set; }

        public static implicit operator ProfessorExam?(Professor? v)
        {
            ProfessorExam p = new ProfessorExam() 
            {
                Professor = v, Subject = v!.ProfessorSubject.Subject
            };
            return p;
            throw new NotImplementedException();
        }
    }
}
