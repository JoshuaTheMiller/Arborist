using System;

namespace GraphQl
{
    public sealed class Query : Operation
    {
        protected internal override OperationModel OperationType { get; } = OperationModel.Query;

        public Query(string alias, SelectionSet selectionSet) : base(alias, selectionSet)
        {

        }

        public static Query Empty(string alias)
        {
            return new Query(alias, SelectionSet.Empty());
        }

        public void AddField(Field field)
        {
            this.SelectionSet.AddField(field);
        }
    }
}