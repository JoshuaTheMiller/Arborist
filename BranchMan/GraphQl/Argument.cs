namespace GraphQl
{
    public sealed class Argument
    {
        private Argument(string name, string value, ArgumentType type)
        {
            Name = name;
            Value = value;
            Type = type;
        }

        public string Name { get; }
        public string Value { get; }
        internal ArgumentType Type { get; }

        public static Argument CreateTextArgument(string name, string value)
        {
            return new Argument(name, value, ArgumentType.Text);
        }

        public static Argument CreateValueArgument(string name, object value)
        {
            return new Argument(name, value.ToString(), ArgumentType.Value);
        }
    }
}