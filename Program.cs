using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int numero;

            Console.WriteLine("Digite um numero de 1 a 10");
            
            numero = int.Parse(Console.ReadLine());

            if (numero > 10) {
                Console.WriteLine("Digite um numero válido...");
                Console.ReadKey();
                Console.Clear();
                Main(null); // pode ser usar o comando return para fechar o programa //return;
                

            }
            else{
                Console.WriteLine("----- FIM DO PROGRAMA-----");
            }

            Console.ReadKey(); */

            string usuario_base;
            string senha_base;
            string usuario_1;
            string senha1;
            string usuario_a;
            string senha_a;
            int escolha;

            Console.WriteLine("Bem-Vindo ao Xurrasco Bank\nSelecione uma opção:");
            Console.WriteLine("1 - Cadastrar\n2 - login");
            escolha = int.Parse(Console.ReadLine());
            
            if(escolha == 1){
                Console.WriteLine("Bem-Vindo a área e cadastro.\n Por favor informe um nome de usuário:");
                usuario_1 = Console.ReadLine();
                Console.WriteLine("\nAgora crie uma senha:");
                senha1 = Console.ReadLine();
                Console.WriteLine("\nUsuário cadastrado com sucesso!\n");
                Console.WriteLine("------ LOGIN DE USUÁRIO ------\n");
                Console.WriteLine("Informe o nome de usuário: ");
                usuario_a = Console.ReadLine();

                if (usuario_a == usuario_1)
                {

                    Console.WriteLine("Está Correto, agora informe a senha:");
                    senha_a = Console.ReadLine();

                    if (senha_a == senha1)
                    {
                        Console.WriteLine("------Login feito com sucesso.");
                        Console.ReadLine();
                        Console.Clear();
                        
                        return;
                        

                    }
                    else
                    {
                        Console.WriteLine("Senha Incorreta.");
                        Console.ReadLine();
                        Console.Clear();
                        Main(null);
                        return;


                    }

                }
                else
                {
                    Console.WriteLine("Usuário não exitente.");
                    Console.ReadLine();
                    Console.Clear();
                    Main(null);
                    return;
                }

               
            }

            if(escolha == 2 ) {
                Console.WriteLine("------ LOGIN DE USUÁRIO ------\n");
                Console.WriteLine("Informe o nome de usuário: ");
                usuario_base = Console.ReadLine();
                Console.WriteLine("Informe a senha: ");
                senha_base = Console.ReadLine();

                if(usuario_base == "Adm")
                {
                    if(senha_base == "senha"){
                        Console.WriteLine("----- LOGIN FEITO COM SUCESSO!");
                        Console.ReadLine();
                        return;
                    }
                    else 
                    {
                        Console.WriteLine("Usuário ou Senha Inválidos.");
                        Console.ReadLine();
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Usuário ou Senha Inválidos.");
                    Console.ReadLine();
                    return;
                }

               

            }

            /* if(usuario_a == usuario_1){

                     Console.WriteLine("Está Correto, agora informe a senha:");
                    senha_a = Console.ReadLine();

                     if(senha_a == senha1){
                         Console.WriteLine("Parabéns! Login feito com sucesso.");
                         Console.ReadLine();
                         return;

                     }else{
                         Console.WriteLine("Senha Incorreta.");

                     }

                 }else{
                     Console.WriteLine("Usuário não exitente.");
                 } */





            Console.ReadKey();
        }
    }
}
