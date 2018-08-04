namespace GraphQl
{
    public static class OperationFactory
    {
        public static Operation CreateQuery(string name, SelectionSet selectionSet)
        {
            return new Query(name, selectionSet);
        }

        public static Operation CreateQuery(SelectionSet selectionSet)
        {
            return new Query(string.Empty, selectionSet);
        }
    }
}