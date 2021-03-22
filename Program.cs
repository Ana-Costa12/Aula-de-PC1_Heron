using System;

namespace Aula_de_PC1_Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cálculo da área de um triângulo//
           double l1;
           double l2;
           double l3;
           double semiP;
           double area;

           Console.ForegroundColor = ConsoleColor.DarkMagenta;
           Console.WriteLine("---------------------------------------");
           Console.WriteLine("!Vamos calcular a área de um triângulo!");
           Console.WriteLine("---------------------------------------");
           Console.ResetColor();

          //Informação sobre o valor dos lados//
           Console.WriteLine("\nPrimeiramente, digite o valor dos três lados:\n");
           Console.WriteLine("Lado 1:");
           Console.ForegroundColor = ConsoleColor.DarkGreen;
           l1 = double.Parse(Console.ReadLine());
           Console.ResetColor();

           Console.WriteLine("\nLado 2:");
           Console.ForegroundColor = ConsoleColor.DarkBlue;
           l2 = double.Parse(Console.ReadLine());
           Console.ResetColor();

           Console.WriteLine("\nLado 3:");
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           l3 = double.Parse(Console.ReadLine());
           Console.ResetColor();

           Console.WriteLine("\nTudo certo! Pressione qualquer tecla para ler os resultados:");
           Console.ReadKey();
           Console.Clear();

           //Indicar valor de semiperímetro e área//
           semiP = (l1 + l2 + l3)/2;
           Console.WriteLine($"Seu semiperímetro é: {semiP}");
           area = Math.Sqrt(semiP * (semiP - l1) * (semiP - l2) * (semiP - l3));
           Console.ForegroundColor = ConsoleColor.DarkBlue;
           Console.WriteLine($"\nPortanto sua área é exaramente: {area}");
           Console.ResetColor();
           Console.WriteLine("\nTecle enter para fechar o programa...");
           Console.ReadLine();
           Console.Clear();
        }
    }
}
