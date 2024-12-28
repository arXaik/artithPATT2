namespace ArithmeticExpression
{
    public class Operator : IExpression
    {
        public char Symbol { get; }
        public IExpression Left { get; }
        public IExpression Right { get; }

        public Operator(char symbol, IExpression left, IExpression right)
        {
            Symbol = symbol;
            Left = left;
            Right = right;
        }

        public void Print()
        {
            Console.Write("(");
            Left.Print();
            Console.Write(" " + Symbol + " ");
            Right.Print();
            Console.Write(")");
        }

        public int Evaluate(Dictionary<string, int> variables)
        {
            int leftValue = Left.Evaluate(variables);
            int rightValue = Right.Evaluate(variables);

            return Symbol switch
            {
                '+' => leftValue + rightValue,
                '-' => leftValue - rightValue,
                '*' => leftValue * rightValue,
                '/' => leftValue / rightValue,
                _ => throw new InvalidOperationException("Неизвестный оператор: " + Symbol)
            };
        }
    }
}
