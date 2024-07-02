namespace iff;



internal class Program
{
    static void Main(string[] args)
    {
        //N1
        Console.WriteLine("Число 1 от 9999");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0 || number > 9999)
        {
            Console.WriteLine("Число или больше 9999 или меньше 1!");
            return;
        }
        int digit = number % 10;
        int digit2 = number % 100;
        if (digit == 1 && digit2 != 11)
        {
            Console.WriteLine($"{number} Доллар");
        }
        else if ((digit == 2 || digit == 3 || digit == 4) && (digit2 != 12 && digit2 != 13 && digit2 != 14))
        {
            Console.WriteLine($"{number} Доллара");
        }
        else
        {
            Console.WriteLine($"{number} Долларов");
        }
        //N2
        Console.WriteLine($"Number ");
        int numb = Convert.ToInt32(Console.ReadLine());

        bool temp = true;
        double x = Math.Sqrt(numb);
        bool Prime = (numb <= 1) ? true : false;

        if (!Prime)
        {
            for (int i = 2; i <= x; i++)
            {
                if (numb % i == 0)
                {
                    temp = false;
                    break;
                }
            }
        }
        if (temp)
        {
            Console.WriteLine($"Number {numb} is  simple.");
        }
        else
        {
            Console.WriteLine($"Number {numb} is not  simple.");
        }
        //N3
        Console.WriteLine("Number: ");
        string numbr = Console.ReadLine();
        char[] array = numbr.ToCharArray();







        while (numbr is string)
        {

            Array.Reverse(array);
            string Str = new string(array);



            Console.WriteLine($"Reversed number: {Str}");
            break;
        }
        // N4
        Console.Write("Number: ");
        int numberr = Convert.ToInt32(Console.ReadLine());
        string str = numberr.ToString();
        int length = str.Length;
        int result = 0;
        int temppp = numberr;

        while (temppp > 0)
        {
            int n = temppp % 10;
            result += (int)Math.Pow(n, length);
            temppp /= 10;
        }

        if (result != numberr)
        {
            Console.WriteLine($"Number {numberr} is not Armstrong");
        }
        else
        {
            Console.WriteLine($"Number {numberr} is Armstrong");
        }
        //N5
        Console.WriteLine("Rate ");
        double P = Convert.ToDouble(Console.ReadLine());
        int months = 0;
        double dep = 10000;
        double tempp = dep * P / 100;
        while( dep <= 11000)
        {
            dep += tempp;
            months++;
        }
        Console.WriteLine($"Months: {months}");
        Console.WriteLine($"Summa  {dep} ");
    }
}
