using System;
using System.Collections.Generic;

namespace Lib
{
    public static class Exercises
    {
        public static void ShowExercise()
        {
            var exercises = GetExercises();
            var index = 1;

            foreach (var item in exercises)
            {
                var msg = $"{index++}. {item}";
                Console.WriteLine(msg);
                Console.WriteLine();
            }
        }

        static List<string> GetExercises()
        {
            return new List<string>
            {
                "Zamień tło całej niebieskiej linii tak, żeby niebieski pojawiał się tylko pod tekstem.",
                "Wypchnij zmiany do repozytorium..."
            };
        }
    }

}
