using System;
using System.Collections.Generic;
using System.Text;

namespace TiposFuncionarios
{
    abstract class Funcionario
    {
        //propriedades
        public string Nome { get; set; }
        public int AnoNasc { get; set; }
        public int  Idade { get; set; }
        public string Telefone { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public double  Inss { get; set; }
        public double Irrf { get; set; }
        public Endereco Endereco { get; set; }

        //Construtor
        public Funcionario()
        {
            AnoNasc = 0;
            Nome = null;
            Idade = 0;
            Telefone = null;
            SalarioBruto = 0;
            SalarioLiquido = 0;
            Inss = 0;
            Irrf = 0;
            Endereco = new Endereco();

        }
        //Metodos Sobrecarregados (override) - virtual
        public virtual void LerDados()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Ano Nasc.: ");
            AnoNasc =Convert.ToInt32(Console.ReadLine());

            //Chamar execução do metodo calcular idade
            CalcularIdade();

            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();

            Endereco.LerDados();

        }
        public virtual string MostrarDados()
        {
            return "\nNome: " + Nome +
                    "\nAno Nasc.: " + AnoNasc +
                    "\nIdade: " + Idade + " Anos" +
                    "\nTelefone: " + Telefone +
                    "\nSalario Bruto R$ " + SalarioBruto +
                    "\nDescontos INSS R$ " + Inss +
                    "\nIRRF R$" + Irrf +
                    "\nSalario Liquido R$ " + SalarioLiquido +
                     Endereco.MostrarDados();
        }
        private void CalcularIdade()
        {
            Idade = DateTime.Now.Year - AnoNasc;
        }

        protected void CalcularINSS()
        {
            if (SalarioBruto <= 1212)
            {
                Inss = SalarioBruto * 0.075;
            }
            else if (SalarioBruto > 1212 & SalarioBruto <= 2427.35)
            {
                Inss = SalarioBruto * 0.09;
            }
            else if (SalarioBruto > 2427.35 & SalarioBruto <= 3641.03)
            {
                Inss = SalarioBruto * 0.12;
            }
            else if (SalarioBruto > 3641.03 & SalarioBruto <= 7087.22)
            {
                Inss = SalarioBruto * 0.14;
            }
            else
            {
                Inss = 828.39;
            }

        }
        protected void CalcularIRRF()
        {
            if (SalarioBruto >= 1903.99 & SalarioBruto <= 2826.65)
            {
                Irrf = SalarioBruto * 0.075;
            }
            else if (SalarioBruto > 2826.65 & SalarioBruto <= 3751.05)
            {
                Irrf = SalarioBruto * 0.15;
            }
            else if (SalarioBruto > 3751.05 & SalarioBruto <= 4664.68)
            {
                Irrf = SalarioBruto * 0.225;
            }
            else if (SalarioBruto > 4664.68 )
            {
                Irrf = SalarioBruto * 0.275;
            }
           
        }
        // definir assinatura do metodo abstrato
        //Sera implementado na classe concreta
        public abstract void CalcularSalario();

    }
}
