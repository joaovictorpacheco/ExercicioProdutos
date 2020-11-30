using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declação de variáveis

            string[] names = new string[10];
            float[] prices = new float[10];
            bool[] promotions = new bool[10];
            


            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--------Sistema de produtos--------");
            Console.WriteLine("-----------------------------------");
           
             //Criar o menu
             int option;
             
             do{
                 MostrarMenu();

                 switch (option){
                     case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;
                    case 0:
                        Console.WriteLine("Fim.");
                        break;
                    }                 
                }while (option != 0);

                int MostrarMenu(){
                    Console.WriteLine("Menu Incial");
                    Console.WriteLine("[1] - Cadastrar produto");
                    Console.WriteLine("[2] - Listar produtos");
                    Console.WriteLine("[0] - Sair");
                    option = int.Parse(Console.ReadLine());
                }
                void CadastrarProduto(){
                string answer;
                int contador = 0;

                do{
                    if(contador < names.Length){
                        Console.Write($"Digite o nome do {contador+1}° produto: ");
                        names[contador] = Console.ReadLine();

                        Console.Write($"Digite o preço do {contador+1}° produto: ");
                        prices[contador] = float.Parse(Console.ReadLine());

                        Console.Write($"Digite o preço do {contador+1}° produto: ");
                        promotions[contador] = bool.Parse(Console.ReadLine());

                        contador++;
                    } else {
                        Console.WriteLine("Limite excedido. ");
                    }  

                    System.Console.WriteLine("Gostaria de adicionar mais um produto? ");
                    System.Console.WriteLine("[S] - Sim");
                    System.Console.WriteLine("[N] - Não");
                    answer = Console.ReadLine();

                } while(answer.ToUpper() == "S");
            }

            void ListarProdutos(){
                for(int i = 0; i < names.Length; i++){
                    Console.WriteLine($"(i+1)° produto Nome: {names[i]}");

                    Console.WriteLine($"(i+1)° produto Preço: {prices[i]}");

                    if(promotions [i] == true){
                        Console.WriteLine($"(i+1)° produto - Promoção : Ativa");
                    }else {
                        Console.WriteLine($"(i+1)° produto - Promoção : Inativa");
                    }
                }
            }


            
            
        }
    }
}
