using System;

namespace VP_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================== Visual Programming Assignment ====================");
                Console.WriteLine("1. Even or Odd Checker");
                Console.WriteLine("2. Simple Calculator");
                Console.WriteLine("3. Grade Evaluator");
                Console.WriteLine("4. Sum of Natural Numbers");
                Console.WriteLine("5. Multiplication Table");
                Console.WriteLine("6. Factorial Calculator");
                Console.WriteLine("7. Reverse a Number");
                Console.WriteLine("8. Array - Find Maximum and Minimum");
                Console.WriteLine("9. Array - Count Even and Odd Numbers");
                Console.WriteLine("10. Array - Search Element");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice (0–10): ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Press any key to try again.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();
                switch (choice)
                {
                    case 1: EvenOdd(); break;
                    case 2: SimpleCalculator(); break;
                    case 3: GradeEvaluator(); break;
                    case 4: SumOfNatural(); break;
                    case 5: MultiplicationTable(); break;
                    case 6: FactorialCalculator(); break;
                    case 7: ReverseNumber(); break;
                    case 8: ArrayMaxMin(); break;
                    case 9: CountEvenOddArray(); break;
                    case 10: ArraySearch(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid choice."); break;
                }

                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }

        static void EvenOdd()
        {
            Console.WriteLine("=== Even or Odd Checker ===");
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int num))
                Console.WriteLine(num % 2 == 0 ? $"{num} is even." : $"{num} is odd.");
            else
                Console.WriteLine("Invalid input.");
        }

        static void SimpleCalculator()
        {
            Console.WriteLine("=== Simple Calculator ===");
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Invalid number."); return; }
            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Invalid number."); return; }

            Console.Write("Choose operation (+, -, *, /): ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+": Console.WriteLine($"Result = {a + b}"); break;
                case "-": Console.WriteLine($"Result = {a - b}"); break;
                case "*": Console.WriteLine($"Result = {a * b}"); break;
                case "/": Console.WriteLine(b == 0 ? "Cannot divide by zero." : $"Result = {a / b}"); break;
                default: Console.WriteLine("Unknown operation."); break;
            }
        }

        static void GradeEvaluator()
        {
            Console.WriteLine("=== Grade Evaluator ===");
            Console.Write("Enter marks (0–100): ");
            if (!int.TryParse(Console.ReadLine(), out int marks) || marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks."); return;
            }
            string grade = marks >= 85 ? "A" : marks >= 70 ? "B" : marks >= 55 ? "C" : marks >= 40 ? "D" : "F";
            Console.WriteLine($"Grade: {grade}");
        }

        static void SumOfNatural()
        {
            Console.WriteLine("=== Sum of Natural Numbers ===");
            Console.Write("Enter n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 1) { Console.WriteLine("Invalid input."); return; }
            long sum = 0;
            for (int i = 1; i <= n; i++) sum += i;
            Console.WriteLine($"Sum = {sum}");
        }

        static void MultiplicationTable()
        {
            Console.WriteLine("=== Multiplication Table ===");
            Console.Write("Enter an integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num)) { Console.WriteLine("Invalid input."); return; }
            for (int i = 1; i <= 10; i++) Console.WriteLine($"{num} x {i} = {num * i}");
        }

        static void FactorialCalculator()
        {
            Console.WriteLine("=== Factorial Calculator ===");
            Console.Write("Enter a non-negative integer: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0) { Console.WriteLine("Invalid input."); return; }
            long result = 1;
            int i = 1;
            while (i <= n)
            {
                result *= i;
                i++;
            }
            Console.WriteLine($"{n}! = {result}");
        }

        static void ReverseNumber()
        {
            Console.WriteLine("=== Reverse a Number ===");
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            bool neg = input.StartsWith("-");
            string digits = neg ? input.Substring(1) : input;
            char[] arr = digits.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr).TrimStart('0');
            if (reversed == string.Empty) reversed = "0";
            Console.WriteLine($"Reversed: {(neg ? "-" : "")}{reversed}");
        }

        static void ArrayMaxMin()
        {
            Console.WriteLine("=== Array - Find Max and Min ===");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter #{i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    Console.Write("Invalid. Try again: ");
            }
            int max = arr[0], min = arr[0];
            foreach (int x in arr)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine($"Max = {max}, Min = {min}");
        }

        static void CountEvenOddArray()
        {
            Console.WriteLine("=== Count Even and Odd in Array ===");
            int[] arr = new int[10];
            int even = 0, odd = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter #{i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    Console.Write("Invalid. Try again: ");
                if (arr[i] % 2 == 0) even++; else odd++;
            }
            Console.WriteLine($"Even: {even}, Odd: {odd}");
        }

        static void ArraySearch()
        {
            Console.WriteLine("=== Array - Search Element ===");
            Console.Write("Enter number of elements: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 1) { Console.WriteLine("Invalid size."); return; }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter #{i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    Console.Write("Invalid. Try again: ");
            }
            Console.Write("Enter number to search: ");
            if (!int.TryParse(Console.ReadLine(), out int target)) { Console.WriteLine("Invalid number."); return; }
            int index = Array.IndexOf(arr, target);
            Console.WriteLine(index >= 0 ? $"Found at position {index + 1}." : "Not found.");
        }
    }
}
