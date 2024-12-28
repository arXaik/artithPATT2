namespace ArithmeticExpression
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, Variable> _variables = new Dictionary<string, Variable>();
        private readonly Dictionary<int, Constant> _constants = new Dictionary<int, Constant>();

        public Variable GetVariable(string name)
        {
            if (!_variables.ContainsKey(name))
            {
                _variables[name] = new Variable(name);
            }
            return _variables[name];
        }

        public Constant GetConstant(int value)
        {
            if (!_constants.ContainsKey(value))
            {
                _constants[value] = new Constant(value);
            }
            return _constants[value];
        }
    }
}
