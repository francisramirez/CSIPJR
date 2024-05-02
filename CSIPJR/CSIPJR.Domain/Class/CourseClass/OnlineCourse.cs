

using CSIPJR.Domain.Class.Core;

namespace CSIPJR.Domain.Class.CourseClass
{
    public class OnlineCourse : Course
    {
        private readonly IEmailSender emailSender;

        public OnlineCourse(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }
        public string? Url { get; set; } 
        public override void Subscribe(Estudiante estudiante)
        {
            throw new NotImplementedException();

            // Enviar notificacion //

            // Enviar Notificacion

            this.emailSender.SendEmail(new Email() { });

            //Realizar proceso de pago //
        }
    }
}
