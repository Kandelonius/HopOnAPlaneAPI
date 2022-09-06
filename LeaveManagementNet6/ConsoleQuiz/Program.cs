/*
int invalidNumbers = 0;
int NaNs = 0;
int[] ints = new int[10];
string[] given = { "7", "2", "4", "2", "q", "87", "4", "6", "4", "4", "7" };
for (int i = 0; i < given.Length; i++)
{
    int number;
    bool isParsable = Int32.TryParse(given[i], out number);
    if (isParsable)
    {
        if (number >= 0 && number <= 10)
        {
            ints[number]++;
        }
        else 
            invalidNumbers++;
    }
    else
        NaNs++;
}
for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] > 0)
    {
        Console.WriteLine($"#{i}:\t{ints[i]}");
    }
}
Console.WriteLine($"invalid:\t{invalidNumbers}");
Console.WriteLine($"NAN:\t{NaNs}");
*/
namespace ConsoleQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int invalidNumbers = 0;
            int NaNs = 0;
            int enteredNumber = 0;
            int[] ints = new int[11];
            Console.WriteLine("Please enter numbers between 0 and 10");
            TakeUserInput(enteredNumber, ints, ref invalidNumbers, ref NaNs);
            PrintResults(ints, ref NaNs, ref invalidNumbers);
            Console.ReadKey();
        }

        private static void PrintResults(int[] ints, ref int naNs, ref int invalidNumbers)
        {
            Console.WriteLine("{0,-12}{1,-6}", "InputValue", "Count");

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > 0)
                {
                    Console.WriteLine("{0,5}{1,10}", i, ints[i]);
                }
            }
            Console.WriteLine("Number of invalid entries: {0}", invalidNumbers);
            Console.WriteLine("Number of non numeric characters: {0}", naNs);
        }

        static void IncrementNANS(ref int naNs)
        {
            naNs++;
        }

        static void FillValidInts(int entered, int[] ints)
        {
            ints[entered]++;
        }

        static void IncrementInvalidNumbers(ref int invalidNumbers)
        {
            invalidNumbers++;
        }
        public static void TakeUserInput(int enteredNumber, int[] ints, ref int invalidNumbers, ref int NaNs)
        {
            Boolean keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Please enter a number");
                if (Int32.TryParse(Console.ReadLine(), out enteredNumber))
                {
                    if (enteredNumber == -1)
                    {
                        keepGoing = false;
                    }
                    else
                    if (enteredNumber >= 0 && enteredNumber <= 10)
                    {
                        FillValidInts(enteredNumber, ints);
                    }
                    else
                    {
                        Console.WriteLine("Number {0} not within range", enteredNumber);
                        IncrementInvalidNumbers(ref invalidNumbers);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Data type");
                    IncrementNANS(ref NaNs);
                }
            }
        }
    }
}