using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using static System.Console;

namespace DeliveryCharges {
    class Program {
        static void Main(string[] args) {
            int[] zips = { 29640, 30047, 44004, 60067, 06082, 08873, 07093, 91762, 01844, 44024 };
            double[] charge = { 5.3, 2.58, 8.4, 3.5, 15.2, 6.8, 6.2, 8.9, 7.6, 4.5 };

            Write("Enter zip code: ");
            bool valid = Int32.TryParse(ReadLine(), out int zip);

            while (!valid) {
                Write("Enter zip code: ");
                valid = Int32.TryParse(ReadLine(), out zip);
            }

            bool contains = zips.Contains(zip);
            if (contains) {
                WriteLine("The delivery cost is: {0}", charge[Array.IndexOf(zips, zip)]);
            }
            else {
                WriteLine("The zip code isn't in the delivery area.");
            }
        }
    }
}
