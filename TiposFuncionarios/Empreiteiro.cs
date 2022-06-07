using System;
using System.Collections.Generic;
using System.Text;

namespace TiposFuncionarios
{
    class Empreiteiro : Funcionario
    {
        //propriedades
        public double SalarioProducao { get; set; }
        public int QtdHorasTrabalhadas { get; set; }

        //metodos
        public override void LerDados()
        {
            base.LerDados();
            Console.Write("Salario Produção R$: ");
            SalarioProducao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade de horas trabalhas : ");
            QtdHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
        }

        public override string MostrarDados()
        {
            Console.WriteLine("-------Exibindo Dados Empreiteiro--------");
            return base.MostrarDados() +
                "\nSalario Produção R$: " + SalarioProducao +
                "\nQuantidade de horas Trabalhadas: " + QtdHorasTrabalhadas + "horas";
        }

        public override void CalcularSalario()
        {
            base.SalarioBruto = QtdHorasTrabalhadas * SalarioProducao;
            base.CalcularINSS();
            base.CalcularIRRF();
            base.SalarioLiquido = base.SalarioBruto - base.Inss - base.Irrf;
        }
    }
}
