namespace ArithmeticExpression
{
    public class Constant : IExpression
    {
        public int Value { get; }

        public Constant(int value)
        {
            Value = value;
        }

        public void Print()
        {
            Console.Write(Value);
        }

        public int Evaluate(Dictionary<string, int> variables)
        {
            return Value;
        }
    }
}
