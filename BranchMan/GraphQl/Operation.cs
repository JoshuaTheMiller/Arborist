namespace GraphQl
{
    public abstract class Operation : GraphQlPart
    {
        public override GraphQlPartType PartType { get; } = GraphQlPartType.Operation;

        protected Operation(string @alias, SelectionSet selectionSet)
        {
            Alias = alias;
            SelectionSet = selectionSet;
        }

        protected internal abstract OperationModel OperationType { get; }

        public string Alias { get; }

        public SelectionSet SelectionSet { get; }
    }
}
