namespace GraphQl
{
    public sealed class Fragment
    {
        public string TypeCondition { get; }
        public DirectiveSet Directives { get; }
        public SelectionSet SelectionSet { get; }
    }
}