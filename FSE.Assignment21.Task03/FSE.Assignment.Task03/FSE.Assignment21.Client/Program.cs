using System;

namespace FSE.Assignment21.Client
{
    class Program
    {
        static int number1, number2;
        static void Main(string[] args)
        {
            Console.WriteLine("Provide the operation to perform \r\n 1.Add\r\n 2.Subtract");
            var operation = Console.ReadLine();
            int op = -1;
            Int32.TryParse(operation, out op);
            switch (op)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Subtract();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            Console.Read();
        }
        static void Add()
        {
            GetInput();
            using (var client = new SimpleCalculatorServiceReference.SimpleCalculatorServiceClient())
            {
                Console.WriteLine($"Output: {client.Add(number1, number2)}");
            }
        }
        static void Subtract()
        {
            GetInput();
            using (var client = new SimpleCalculatorServiceReference.SimpleCalculatorServiceClient())
            {
                Console.WriteLine($"Output: {client.Subtract(number1, number2)}");
            }
        }
        static void GetInput()
        {
            Console.WriteLine("Provide 1st Input:");
            var input1 = Console.ReadLine();
            Int32.TryParse(input1, out number1);
            Console.WriteLine("Provide 2nd Input:");
            var input2 = Console.ReadLine();
            Int32.TryParse(input2, out number2);
        }
    }
}