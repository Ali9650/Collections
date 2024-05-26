namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> calculator = new Calculator<int>(10, 5);

            while (true)
            {
                Console.WriteLine("Meynuya kecid");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");
                Console.WriteLine("5. Exit");
               
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case (int)Operation.Exit:
                        Console.WriteLine("program basa catdi"); ;
                        break;
                    case (int)Operation.Addition:
                        Console.WriteLine(calculator.Addition());
                        break;
                    case (int)Operation.Subtraction:
                        Console.WriteLine(calculator.Substraction());
                        break;
                    case (int)Operation.Division:
                        Console.WriteLine(calculator.Division());
                        break;
                    case (int)Operation.Multiplication:
                        Console.WriteLine(calculator.Multiplication());
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim! Zəhmət olmasa düzgün seçim edin.");
                        break;
                }
            }
        }
    }
}
