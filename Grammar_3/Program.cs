namespace _1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

            Console.WriteLine();

            Console.WriteLine("관계연산자");
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine();

            Console.WriteLine("논리연산자");

            int num3 = 15;

            Console.WriteLine(0 <= num3 && num3 <= 20);
            Console.WriteLine(0 > num3 || num3 > 20);

            Console.WriteLine();

            string str1 = "Apple";
            string str2 = "apple";
            int compare = string.Compare(str1, str2);
            Console.WriteLine(compare);
        }
    }
}