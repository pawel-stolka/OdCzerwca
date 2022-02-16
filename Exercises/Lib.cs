using System;
using System.Collections.Generic;

namespace Exercises
{
    public static class Lib
    {
        public static void ShowExercise()
        {
            var exercises = Exercises();
            var index = 1;

            foreach (var item in exercises)
            {
                var msg = $"{index++}. {item}";
                Console.WriteLine(msg);
                Console.WriteLine();
            }
        }

        static List<string> Exercises()
        {
            return new List<string>
            {
                "Zamień tło całej niebieskiej linii tak, żeby niebieski pojawiał się tylko pod tekstem.",
                "Wypchnij zmiany do repozytorium..."
            };
        }
    }

}
