using System;

namespace TiposFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;   
            do
            {
                try
                {                
                    Console.Clear();

                    if (aux == 5 || aux > 4 || aux < 0)
                        Console.WriteLine("--Escolha uma Opção Valida!!\n");

                    Console.WriteLine("*******MENU***********");
                    Console.WriteLine("Digite a Letra que corresponde ao funcionario:");
                    Console.WriteLine("1-Horista");
                    Console.WriteLine("2-Empreiteiro");
                    Console.WriteLine("3-Mensalista");
                    Console.WriteLine("4-Comissionado");
                    Console.WriteLine("0-SAIR");
                    Console.Write("Opçao->");

                   
                    aux = Convert.ToInt32(Console.ReadLine());
                }catch(Exception ex)
                {               
                    aux = 5;
                }
               
                Funcionario fun = null;       

                switch (aux)
                {
                    case 1:
                        fun = new Horista();
                        Console.Clear();
                        Console.WriteLine("--------Cadastro Horista-------------");                  
                        break;
                    case 2:
                        fun = new Empreiteiro();
                        Console.Clear();
                        Console.WriteLine("--------Cadastro Empreiteiro-------------");
                        break;
                    case 3:
                        fun = new Mensalista();
                        Console.Clear();
                        Console.WriteLine("--------Cadastro Mensalista-------------");                      
                        break;
                    case 4:
                        fun = new Comissionario();
                        Console.Clear();
                        Console.WriteLine("--------Cadastro Comissionado----------");                                         
                        break;
                }
                if (fun != null)
                {
                    fun.LerDados();
                    fun.CalcularSalario();
                    Console.Clear();
                    Console.WriteLine(fun.MostrarDados());
                    Console.WriteLine("\n\nPresione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            } while (aux != 0);
           
        }
    }
}
