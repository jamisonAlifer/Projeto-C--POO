using System;
using System.Collections.Generic;
using System.Text;

namespace TiposFuncionarios
{
    class Horista : Funcionario
    {
        public double SalarioHora { get; set; }
        public int QdeHorasTrabalhadas { get; set; }

        public override void LerDados()
        {
            base.LerDados();

            Console.Write("Salario Hora R$ : ");
            SalarioHora = Convert.ToDouble(Console.ReadLine());


            Console.Write("Quantidade de horas trabalhadas : ");
            QdeHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
        }
        public override string MostrarDados()
        {
            Console.WriteLine("-------Exibindo Dados Hostista-------");
            return base.MostrarDados() +
                "\nSalario Hora R$ " + SalarioHora +
                "\nQuantidade de Horas Trabalhadas " + QdeHorasTrabalhadas + " horas";

        }
        public override void CalcularSalario()
        {
            base.SalarioBruto = QdeHorasTrabalhadas * SalarioHora * 4.5;
            base.CalcularINSS();
            base.CalcularIRRF();
            base.SalarioLiquido = base.SalarioBruto - base.Inss - base.Irrf;
        }
    }
}
