using System;
using static System.Console;

namespace ArrayDemo2 {
    class Program {
        static void Main(string[] args) {
            int[] scores = new int[8];
            int x;
            string inputString;

            for (x = 0; x < scores.Length; ++x) {
                Write("Enter your score on test {0}: ", x + 1);
                inputString = ReadLine();
                scores[x] = Convert.ToInt32(inputString);
            }

            WriteLine("\n-----------------------------");
            WriteLine("Scores in original order:");
            for (x = 0; x < scores.Length; ++x) {
                Write("{0, 6}", scores[x]);
            }

            WriteLine("\n-----------------------------");
            Array.Sort(scores);
            WriteLine("Scores in sorted order:");
            for (x = 0; x < scores.Length; ++x) {
                Write("{0, 6}", scores[x]);
            }

            WriteLine("\n-----------------------------");
            Array.Reverse(scores);
            WriteLine("Scores in reverse order:");
            for (x = 0; x < scores.Length; ++x) {
                Write("{0, 6}", scores[x]);
            }
        }
    }
}
