namespace CSIPJR.Domain.Class.CourseClass
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public string? Area { get; set; }
        public int Credits { get; set; }

        public abstract void Subscribe(Estudiante estudiante); 
        

    }
}
