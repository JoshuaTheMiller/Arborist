namespace GraphQl
{
    public sealed class Field : GraphQlPart
    {
        public override GraphQlPartType PartType { get; } = GraphQlPartType.Field;

        private Field(string alias, string name, ArgumentSet arguments, DirectiveSet directives, SelectionSet innerSelectionSet)
        {
            Alias = alias;
            Name = name;
            Arguments = arguments;
            Directives = directives;
            InnerSelectionSet = innerSelectionSet;
        }

        public string Alias { get; }
        public string Name { get; }
        public ArgumentSet Arguments { get; }
        public DirectiveSet Directives { get; }
        public SelectionSet InnerSelectionSet { get; }        

        public static Field Simple(string name)
        {
            return new Field(string.Empty, name, ArgumentSet.Empty(), DirectiveSet.Empty(), SelectionSet.Empty());
        }
    }
}