using System;
using static System.Console;

namespace ArrayDemo {
    class Program {
        static void Main(string[] args) {
            int[] nums = { 40, 83, 57, 67, 87, 10, 70, 85 };

            WriteLine("(1)    View the list in order from the first to last position.");
            WriteLine("(2)    View the list in order from the last to first position.");
            WriteLine("(3)    Choose a specific position to view.");
            bool valid = Int32.TryParse(ReadLine(), out int choice);

            while (!valid || (choice <= 0 || choice >= 4) ) {
                WriteLine("(1)    View the list in order from the first to last position.");
                WriteLine("(2)    View the list in order from the last to first position.");
                WriteLine("(3)    Choose a specific position to view.");
                valid = Int32.TryParse(ReadLine(), out choice);
            }

            switch (choice) {
                case 1:
                    WriteLine("\n-----------------------------");
                    WriteLine("Scores in reverse order:");
                    for (int x = 0; x < nums.Length; ++x) {
                        Write("{0, 4}", nums[x]);
                    }
                    break;
                case 2:
                    WriteLine("\n-----------------------------");
                    Array.Reverse(nums);
                    WriteLine("Scores in reverse order:");
                    for (int x = 0; x < nums.Length; ++x) {
                        Write("{0, 4}", nums[x]);
                    }
                    break;
                case 3:
                    WriteLine("What position would you like to view (1-8)?");
                    bool posvalid = Int32.TryParse(ReadLine(), out int pos);

                    while (!posvalid || (pos < 1 || pos > 8) ) {
                        WriteLine("What position would you like to view (1-8)?");
                        posvalid = Int32.TryParse(ReadLine(), out pos);
                    }

                    WriteLine("The element at {0}, is {1}", pos, nums[pos - 1]);
                    break;
            }
        }
    }
}
