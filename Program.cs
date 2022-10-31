namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((3 * 5 * 7));
            Console.ReadKey(true);
            for (int i = 0; i <10396; i++)
            {
                string output = "";
                if (i % 3 == 0)
                {
                    output = "Fizz";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(output);
                }
                if (i % 5 == 0)
                {
                    output = "Buzz";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(output);
                }
                if (i % 7 == 0)
                {
                    output = "Fuzz";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(output);
                }
                if (i % 9 == 0)
                {
                    output = "Bizz";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(output);
                }
                if (i % 11 == 0)
                {
                    output = "Fezz";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(output);
                }
                if (output == "")
                {
                    output = i.ToString();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(output);
                }
                output = " ";
                Console.Write(output);
            }
            Console.ReadKey(true);
        }
    }
}