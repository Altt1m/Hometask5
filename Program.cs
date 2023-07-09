class Program
{
    static void Main(string[] args)
    {
        // Task 1
        int num = 1;
        int sum = 0;
        while (num > 0 && num < 50) // 0 < num < 50
        {
            if (num % 2 == 1)
            {
                sum += num;
            }
            num++;
        }
        Console.WriteLine($"Task 1: {sum}\n");


        // Task 2
        sum = 0;
        int a = 1;
        int b = 100;
        for (int i = a; i<=b; i++) // Від 1 до 101
        {
            if (i%4 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"Task 2: {sum}\n");


        // Task 3
        int num1 = 10;
        int num2 = 99;

        List<int> numbers = new List<int>();
        for (int i = num1; i<=num2; i++) // a)
        {
            double square_sum = Math.Pow(i % 10, 2) + Math.Pow(i / 10, 2); // Для двозначних чисел
            if (square_sum % 13 == 0)
            {
                numbers.Add(i);
            }
        }

        List<int> numbers2 = new List<int>();
        for (int i = num1; i<=num2; i++) // б)
        {
            double sum_and_square = (i % 10) + (i / 10) + Math.Pow((i % 10) + (i / 10), 2);
            if (sum_and_square == i)
            {
                numbers2.Add(i);
            }
            
        }

        Console.WriteLine("Task 3 (a)");
        foreach (int i in numbers)
        {
            Console.WriteLine($"{i} ");
        }

        Console.WriteLine();

        Console.WriteLine("Task 3 (b)");
        foreach (int i in numbers2)
        {
            Console.WriteLine($"{i} ");
        }
        Console.WriteLine();


        // Task 4
        sum = 0;
        double mult = 1;
        do
        {
            a = new Random().Next(-10, 10);
            b = new Random().Next(-10, 10);
        } while (a >= b);
        Console.WriteLine($"Task 4\na = {a}, b = {b}");

        for (int i = a; i <= b; i++)
        {
            sum += i;
            mult *= i;
        }
        Console.WriteLine($"Sum = {sum}. Multiplication = {mult}");
        Console.WriteLine();


        // Task 5
        do
        {
            a = new Random().Next(-10, 10);
            b = new Random().Next(-10, 10);
        } while (a >= b);
        Console.WriteLine($"Task 5\na = {a}, b = {b}");

        int N = 0;
        for (int i = a; i <= b; i++)
        {
            Console.WriteLine(i);
            N++;
        }
        Console.WriteLine($"N = {N}\n");


        // Task 6
        double price = 85.34;
        double kg = 1;

        Console.WriteLine("Task 6");
        while (kg < 2)
        {
            Console.WriteLine($"{kg:F1} kg of candies cost {kg*price:F2} (UAH?)");
            kg += 0.2;
        }
        Console.WriteLine();


        // Task 7
        do
        {
            a = new Random().Next(1, 5);
            b = new Random().Next(1, 5);
        } while (a >= b);
        Console.WriteLine($"Task 7\na = {a}, b = {b}");
        for (int i = a; i <= b; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(i);
            }
        }


    }
}
