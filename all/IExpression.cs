namespace ArithmeticExpression
{
    public interface IExpression
    {
        void Print();
        int Evaluate(Dictionary<string, int> variables);
    }
}
