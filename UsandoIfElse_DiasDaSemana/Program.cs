using System;

namespace UsandoIfElse_DiasDaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            var diaSemana = DateTime.Now.DayOfWeek;

            Console.WriteLine(" ");
            Console.WriteLine("QUAL É O DIA DA SEMANA DE HOJE?");

            Console.WriteLine(" ");
            Console.WriteLine("Com a estrtutura condicional Switch/Case:");

            switch (diaSemana)
           {
                 case DayOfWeek.Sunday:
                  Console.WriteLine($"  Today is: {DayOfWeek.Sunday}");
                 break;

                case DayOfWeek.Monday:
                  Console.WriteLine($"  Today is: {DayOfWeek.Monday}");
                break;

                case DayOfWeek.Tuesday:
                  Console.WriteLine($"  Today is: {DayOfWeek.Tuesday}");
                break;

                case DayOfWeek.Wednesday:
                  Console.WriteLine($"  Today is: {DayOfWeek.Wednesday}");
                break;

                case DayOfWeek.Thursday:
                 Console.WriteLine($"  Today is: {DayOfWeek.Thursday}");
                break;

               case DayOfWeek.Friday:
                 Console.WriteLine($"  Today is: {DayOfWeek.Friday}");
                break;

                case DayOfWeek.Saturday:
                  Console.WriteLine($"  Today is: {DayOfWeek.Saturday}");
                break;

            }

            Console.WriteLine(" ");
            Console.WriteLine("Com a estrtutura condicional If/Else:");

            var DiasSemana = DateTime.Now.DayOfWeek; 

            if (DiasSemana == DayOfWeek.Sunday)
            {
              Console.WriteLine($"  Today is: {DayOfWeek.Sunday}");  
            }
            else if (DiasSemana == DayOfWeek.Monday)
            {
                Console.WriteLine($"  Today is: {DayOfWeek.Monday}");
            }
            else if (DiasSemana == DayOfWeek.Tuesday)
            {
                Console.WriteLine($"  Today is: {DayOfWeek.Tuesday}");
            }
            else if (DiasSemana == DayOfWeek.Wednesday)
            {
                Console.WriteLine($"  Today is: {DayOfWeek.Wednesday}");
            }
            else if (DiasSemana == DayOfWeek.Thursday)
            {
                Console.WriteLine($"  Today is: {DayOfWeek.Thursday}");
            }
            else if (DiasSemana == DayOfWeek.Friday)
            {
                Console.WriteLine($"  Today is: {DayOfWeek.Friday}");
            }
            else if (DiasSemana == DayOfWeek.Saturday)
            {  
              Console.WriteLine($"  Today is: {DayOfWeek.Saturday}");
            }

            // Resultado de pesquisa, outro método de realizar praticamente a mesma ação:
            /*Console.WriteLine(" ");
            Console.WriteLine("Utilizando a propiedade DateTime.Today:");

              DateTime thisDay = DateTime.Today;
              Console.WriteLine(thisDay.ToString("D"));
            */

            Console.WriteLine(" ");
        }
    }
}