using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть перше число");
            int number1 = InputNumbers();
            Console.WriteLine("Введіть друге число");
            int number2 = InputNumbers();
            switch (InputSing())
            {
                case '+':
                    Console.WriteLine($"Result = {Add(number1, number2)}");
                    break;
                case '-':
                    Console.WriteLine($"Result = {Dif(number1, number2)}");
                    break;
                case '*':
                    Console.WriteLine($"Result = {Mult(number1, number2)}");
                    break;
                case '/':
                    Console.WriteLine($"Result = {Divede(number1, number2)}");
                    break;
                case '^':
                    Console.WriteLine($"Result = {Degrees(number1, number2)}");
                    break;
            }

            Console.ReadLine();
        }
        static int InputNumbers()
        {
            int num;
            while (true)
            {
                bool flag = int.TryParse(Console.ReadLine(), out num);
                if (num == 0 || flag == false)
                {
                    Console.WriteLine("Ви ввели або 0, або символ. Введіть число");
                    continue;
                }
                break;
            }
            return num;
        }
        static char InputSing()
        {
            char sing;
            string sample = "*/-+^";
            Console.WriteLine("Введіть операцію");
            while (true)
            {
                sing = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < sample.Length; i++)
                {
                    if (sing == sample[i])
                        return sing;
                }
            }
        }
        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        static float Dif(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        static float Divede(int num1, int num2)
        {
            return (float)num1 / num2;
        }
        static int Degrees(int num1, int num2)
        {
            int res = 1;
            for (int i = 0; i < num2; i++)
            {
                res *= num1;
            }
            return res;
        }
    }
}
