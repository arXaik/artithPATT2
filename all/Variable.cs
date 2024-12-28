namespace ArithmeticExpression
{
    public class Variable : IExpression
    {
        public string Name { get; }

        public Variable(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.Write(Name);
        }

        public int Evaluate(Dictionary<string, int> variables)
        {
            if (variables.ContainsKey(Name))
                return variables[Name];
            throw new InvalidOperationException("Не найдено: " + Name);
        }
    }
}
    