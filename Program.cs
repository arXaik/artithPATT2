using System;
using System.Collections.Generic;

namespace ArithmeticExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new FlyweightFactory();

            // Создание выражения (a + 5) * (b - 3)
            var a = factory.GetVariable("a");
            var b = factory.GetVariable("b");
            var five = factory.GetConstant(5);
            var three = factory.GetConstant(3);

            // Создание операторов
            var addition = new Operator('+', a, five); // a + 5
            var subtraction = new Operator('-', b, three); // b - 3
            var multiplication = new Operator('*', addition, subtraction); // (a + 5) * (b - 3)

            // Печать выражения
            Console.Write("Выражение: ");
            multiplication.Print();
            Console.WriteLine();

            // Вычисление значения выражения для a = 10, b = 8
            var variables = new Dictionary<string, int> { { "a", 10 }, { "b", 8 } };
            Console.WriteLine("Результат: " + multiplication.Evaluate(variables));
        }
    }
}
