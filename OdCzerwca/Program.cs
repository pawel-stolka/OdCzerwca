using Lib;
using System;

namespace OdCzerwca
{
    class Program
    {
        static int day = 2;

        static void Main(string[] args)
        {
            Intro();
            Space();
            Exercise();
        }

        private static void Exercise()
        {
            Exercises.ShowExercise();
            Console.WriteLine();
        }


        private static void Intro()
        {
            var textBatchToBeConvertedIntoConsoleWriteLines_SeparatedBySemiColons = "Zaczynamy!; W czerwcu możesz zacząć pracę w nowym projekcie, nowym zespole, nowej firmie...; Z nowym nastawieniem zaczynamy teraz :)";

            ShowIntro(textBatchToBeConvertedIntoConsoleWriteLines_SeparatedBySemiColons);

            ShowTime(day);
        }

<<<<<<< HEAD
        private static void ShowIntro(string text)
=======
        private static void ShowIntro(string textBatchToBeConvertedIntoConsoleWriteLines_SeparatedBySemiColons)
>>>>>>> 87c0b57 (next exercise)
        {
            // suppose it should:
            // 1. split input by semi-colons,
            // 2. trim result ('no extra spaces at the end')
            // 3. display the text array in loop... :) 
            throw new NotImplementedException();
        }

        private static void ShowTime(int day)
        {
            var headerMessage = formatDate(day);
            var format = "{0," + ((Console.WindowWidth / 2) + (headerMessage.Length / 2)) + "}";

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(string.Format(format, headerMessage));

            Console.ResetColor();
        }

        private static string formatDate(int day)
        {
            var now = DateTime.Now;
            var date = now.ToShortDateString();
            return $"Dzień {day}. [{date}]";
        }

        private static void Space()
        {
            Console.WriteLine();
        }
    }
}
