using System;
using System.Runtime.Intrinsics.Arm;

namespace JogodaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int chances = 0;          
            string continuar = "S";
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("Dificuldade:\n F: Fácil(15 chances)\n M: Médio(10 chances)\n D: Dificil(5 chances)");
            string dificuldade = "";

            #region WhileDificuldade
            while (dificuldade != "F" && dificuldade != "D" && dificuldade != "M")
            {
                dificuldade = Console.ReadLine().ToUpper();

                if (dificuldade == "F")               
                chances = 15;     
                
                else
                if (dificuldade == "M")
                chances = 10;
                
                else
                if (dificuldade == "D")
                chances = 5;

                else
                 Console.WriteLine(" Erro: Digite uma dificuldade existente....");                   
                
            }
            #endregion

            while (continuar.ToUpper() == "S")
            {
                
                Console.Clear();
                Console.WriteLine(" Dificuldade: "+ dificuldade);
                Console.WriteLine("_________________________________________");
                int pontos = 1000;
                var ramdom = new Random();
                int numeroAleatorio = ramdom.Next(1, 21);

                for (int i = 0; i < chances; i++)
                {
                    Console.WriteLine("_________________________________________\n");
                    Console.WriteLine(" Tentativa " + i + " de " + chances);
                    Console.Write(" Qual o Chute: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());
                    if (numeroDigitado == numeroAleatorio)
                    {
                        Console.Clear();

                        Console.WriteLine("\n\n\n¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                        Console.WriteLine("     Acertou!!!");
                        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                        break;
                    }
                    else
                    if (numeroDigitado > numeroAleatorio)
                    {
                        Console.WriteLine(" O numero aleatorio é menor que isso...");
                        pontos -= Math.Abs((numeroDigitado - numeroAleatorio) / 2);
                        Console.WriteLine(" Pontos: " + pontos);
                    }
                    else
                    if (numeroDigitado < numeroAleatorio)
                    {
                        Console.WriteLine(" O numero aleatorio é maior que isso...");
                        pontos -= Math.Abs((numeroDigitado - numeroAleatorio) / 2);
                        Console.WriteLine(" Pontos: " + pontos);
                    }

                }
                Console.WriteLine("_________________________________________");
                Console.WriteLine(" O Número era " + numeroAleatorio);
                Console.WriteLine(" Você Ficou com " + pontos + " Ponto(s)");
                Console.WriteLine(" S para Tentar novamente: ");
                continuar = Console.ReadLine();
                Console.WriteLine("_________________________________________");

            }         

        }
    }
}
