using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoswitch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //objetivo: solicitar a idade do usuario, e verificar 
            //se a idade >= se sim, vai exibir um menu com os seguintes intems
            //1.fazer cadastro
            //2.consultar cadastro
            //3.sair do sistema
            //para opção 1. solicitar os dados:nome,cidade  e telefone
            //para opção 2. exibir a msg (tente mais tarde), sistema fora do ar
            //para opção 3. exibir msg "ate a proxima"
            //se a idade for menor do que 18, exibir msg
            //menor de idade,

            int idade;
            string nome, cidade, telefone;


            Console.WriteLine("qual seria sua idade?: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("escolha as opções abaixo");
                Console.WriteLine("1-prosseguir cadastro");
                Console.WriteLine("2-cadastrar consulta");
                Console.WriteLine("3-sair do sistema");
                int op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                Console.Write("nome: ");
                nome = Console.ReadLine();     
                Console.Write("cidade: ");
                cidade = Console.ReadLine();
                Console.Write("telefone: ");
                telefone = Console.ReadLine();
                
                Console.WriteLine("dados cadastrais : Ok");
                Console.WriteLine($"nome: {nome} \n cidade: {cidade}\n" + $"telefone : {telefone}");
                break;
                    case 2:
                    Console.WriteLine("tente mais tarde");
                    break;
                case 3:
                    Console.WriteLine("saindo do sistema");
                    break;
                default:
                    Console.WriteLine("escolha uma opção valida");
                    break;
                
                }
            }
            else
            {
                Console.WriteLine("menor de idade");

            }          

        }
    }
}
