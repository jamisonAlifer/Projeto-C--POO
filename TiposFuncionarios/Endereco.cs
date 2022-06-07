using System;
using System.Collections.Generic;
using System.Text;

namespace TiposFuncionarios
{
    class Endereco
    {
        //Propriedades
        public string Rua    { get; set; }
        public int Nro       { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep    { get; set; }

        //Construtor
        public Endereco()
        {
            Rua     = null;
            Nro    = 0;
            Bairro = null;
            Cidade = null;
            Estado = null;
            Cep    = null;

        }
        //metodos
        public void LerDados()
        {
            Console.Write("Rua: ");
            Rua = Console.ReadLine();

            Console.Write("Nro: ");
            Nro = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Bairro: ");
            Bairro = Console.ReadLine();

            Console.Write("Cidade: ");
            Cidade = Console.ReadLine();

            Console.Write("Estado: ");
            Estado = Console.ReadLine();

            Console.Write("CEP: ");
            Cep = Console.ReadLine();
        }
        public string MostrarDados()
        {
            return "\nRua " + Rua + "  No. " + Nro +
                   "\n"+ Bairro + ", " + Cidade +
                   " " + Estado + " CEP " + Cep;
        }
    }
}
 