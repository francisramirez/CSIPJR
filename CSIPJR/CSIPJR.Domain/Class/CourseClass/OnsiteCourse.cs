

using CSIPJR.Domain.Class.Core;

namespace CSIPJR.Domain.Class.CourseClass
{
    public class OnsiteCourse : Course
    {
        private readonly IEmailSender emailSender;

        public OnsiteCourse(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }
        public string? Location { get; set; }
        public int Days { get; set; }

        public override void Subscribe(Estudiante estudiante)
        {
            throw new NotImplementedException();

            // Enviar Notificacion

            this.emailSender.SendEmail(new Email() {  });
        }
    }
}
