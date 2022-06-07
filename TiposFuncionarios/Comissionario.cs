using System;
using System.Collections.Generic;
using System.Text;

namespace TiposFuncionarios
{
    class Comissionario : Funcionario
    {
        //Propriedades
        public double  SalarioBase { get; set; }
        public double Comissao { get; set; }
        public double QdeServico { get; set; }

        //construtores
        public Comissionario() : base()
        {
            SalarioBase = 0;
            Comissao    = 0;
            QdeServico  = 0;
        }
        //metodos
        public override void LerDados()
        {
            string msg = " ";
            try
            {

                base.LerDados();
                Console.Write("Salario Base R$ : ");
                SalarioBase = Convert.ToDouble(Console.ReadLine());

                Console.Write("Comissão R$ : ");
                Comissao = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantide de Serviço Realizado : ");
                QdeServico = Convert.ToDouble(Console.ReadLine());

                msg = "Funcionario Comissionado com sucesso";

            }
            catch (Exception ex)
            {
                 msg = "Erro ao Cadastrar Funcionario Comissionario "+ ex;
            }
            finally
            {
                Console.WriteLine(msg);
            }
        }

        //metodo abstrato
        public override void CalcularSalario()
        {
            base.SalarioBruto = SalarioBase + Comissao * QdeServico;
            base.CalcularINSS();
            base.CalcularIRRF();
            base.SalarioLiquido = base.SalarioBruto - base.Inss - base.Irrf;
        }

        public override string MostrarDados()
        {
            Console.WriteLine("-------Exibindo Dados Comissionado--------");
            return base.MostrarDados() +
                   "\nSalario Base R$ " + SalarioBase +
                   "\nComissão     R$ " + Comissao +
                   "\nQuantidade Serviços Realizados: " + QdeServico;
        }
       
    }
}
