using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using static System.Console;

namespace ChatAWhile {
    class Program {
        static void Main(string[] args) {
            int[] areaCodes = { 262, 414, 608, 715, 815, 920 };
            double[] areaCost = { 0.07, 0.10, 0.05, 0.15, 0.24, 0.14};

            Write("Enter area code: ");
            bool valid = Int32.TryParse(ReadLine(), out int areaCode);

            while (!valid) {
                Write("Enter area code: ");
                valid = Int32.TryParse(ReadLine(), out areaCode);
            }

            Write("Enter length of call in minutes: ");
            bool validMin = Double.TryParse(ReadLine(), out double callTime);

            while (!validMin) {
                Write("Enter length of call in minutes: ");
                validMin = Double.TryParse(ReadLine(), out callTime);
            }

            bool contains = areaCodes.Contains(areaCode);
            if (contains) {
                WriteLine("The call cost is: {0}", (areaCost[Array.IndexOf(areaCodes, areaCode)] * callTime).ToString("C"));
            }
            else {
                WriteLine("The area code isn't supported by our service.");
            }
        }
    }
}
