using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using static System.Console;

namespace WippetBus {
    class Program {
        static void Main(string[] args) {
            Write("Enter distance: ");
            bool valid = Int32.TryParse(ReadLine(), out int distance);

            while (!valid) {
                Write("Enter distance: ");
                valid = Int32.TryParse(ReadLine(), out distance);
            }

            double distanceCost = 25;
            if (distance >= 100 && distance <= 299) {
                distanceCost = 40;
            }
            else if (distance >= 300 && distance <= 499) {
                distanceCost = 55;
            }
            else if (distance >= 500) {
                distanceCost = 70;
            }

            WriteLine("The ticket price is: " + distanceCost);
        }
    }
}
