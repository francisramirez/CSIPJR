namespace CSIPJR.Domain
{
    public abstract class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public abstract void Save();


        public virtual void Load()
        {
            Console.WriteLine("Cargando los datos...");
        }
    }

    public interface IBaseEmployee
    {
        public DateTime HireDate { get; set; }
    }
    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
        public override void Save()
        {
            Console.WriteLine("Guardando la información del estudiante");
        }
    }


    public class Instructor : Person, IBaseEmployee
    {
        public DateTime HireDate { get; set; }
        public override void Save()
        {
             
            Console.WriteLine("Guardando la información del instructor");
        }
        public override void Load()
        {
            Console.WriteLine("Cargando la información del instructor");
        }
    }

    public class Employee : Person, IBaseEmployee
    {
        public DateTime HireDate { get; set; }
        public override void Save()
        {
            Console.WriteLine("Guardando la información del empleado");
        }
    }
}