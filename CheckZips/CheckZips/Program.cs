using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using static System.Console;

namespace CheckZips {
    class Program {
        static void Main(string[] args) {
            int[] zips = {29640, 30047, 44004, 60067, 06082, 08873, 07093, 91762, 01844, 44024};

            Write("Enter zip code: ");
            bool valid = Int32.TryParse(ReadLine(), out int zip);

            while (!valid) {
                Write("Enter zip code: ");
                valid = Int32.TryParse(ReadLine(), out zip);
            }

            bool contains = zips.Contains(zip);
            if (contains) {
                WriteLine("The zip code is in the delivery area.");
            } else {
                WriteLine("The zip code isn't in the delivery area.");
            }
        }
    }
}
