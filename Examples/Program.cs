namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Region1
            //Console.WriteLine("Please, enter yours name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Pleace, enter yours surname: ");
            //string surname = Console.ReadLine();
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Surname: " + surname);
            //Console.WriteLine($"Hello {surname} {name}");
            #endregion
            #region Region2
            Console.WriteLine("Pleace, enter your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Pleace, enter youur second Number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"1.Number {firstNumber}");
            Console.WriteLine($"2.Number {secondNumber}");
            Console.WriteLine("The sum of the first and second number")
            #endregion
            #region Region3

            #endregion

        }
    }
}
