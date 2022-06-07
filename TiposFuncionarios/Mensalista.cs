using System;
using System.Collections.Generic;
using System.Text;

namespace TiposFuncionarios
{
    class Mensalista : Funcionario
    {
        //propriedades
        public string HorarioTrabalho { get; set; }

        //Metodos override
        public override void LerDados()
        {
            base.LerDados();

            Console.Write("Horario de Trabalho: ");
            HorarioTrabalho = Console.ReadLine();

            Console.Write("Salario Bruto R$: ");
            base.SalarioBruto = Convert.ToDouble(Console.ReadLine());
        }

        public override string MostrarDados()
        {
            Console.WriteLine("-------Exibindo Dados Mensalista--------");
            return base.MostrarDados() +
                "\nHorario de Trabalho : " + HorarioTrabalho;
        }
        public override void CalcularSalario()
        {
            base.CalcularINSS();
            base.CalcularIRRF();
            base.SalarioLiquido = base.SalarioBruto - base.Inss - base.Irrf;
        }
    }
}
