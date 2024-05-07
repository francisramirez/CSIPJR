
namespace CSIPJR.Domain.Class
{
    public abstract class CalcularSalario
    {
        public decimal Salario { get; set; }
        public abstract decimal Calcular();

    }

    public class CalcularSalarioContractado : CalcularSalario
    {
        public override decimal Calcular()
        {
            throw new NotImplementedException();
        }
    }
    public class CalcularSalarioPermanente : CalcularSalario
    {
        public override decimal Calcular()
        {
            throw new NotImplementedException();
        }
    }

    public class CalculaSalarioFactory 
    {
        public CalcularSalario GetCalcularSalario(TipoEmpleado tipoEmpleado) 
        {
            CalcularSalario calcularSalario = null;

            if (tipoEmpleado == TipoEmpleado.Contractado)
            {
                calcularSalario = new CalcularSalarioContractado();
            }
            else if(tipoEmpleado == TipoEmpleado.Permanente)
            {
                calcularSalario = new CalcularSalarioPermanente();
            }

            return calcularSalario;
        }
    }

    public enum TipoEmpleado
    {
        Contractado,
        Permanente
    }


}
