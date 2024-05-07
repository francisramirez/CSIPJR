

namespace CSIPJR.Domain.Class
{
    public class Empleado
    {
        public decimal Salario { get; set; }
        public Empleado(CalcularSalario calcular)
        {
            this.Salario = calcular.Calcular();
        }

    }
}
