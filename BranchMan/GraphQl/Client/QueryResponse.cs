namespace GraphQl.Client
{
    public sealed class QueryResponse<T> : QueryResponse
    {
        internal QueryResponse(bool isSuccess, T value) : base(isSuccess, value)
        {
            Value = value;
        }

        public new T Value { get; }       
    }

    public abstract class QueryResponse
    {        
        public bool IsSuccess { get; }
        public object Value { get; }

        protected QueryResponse(bool isSuccess, object value)
        {
            IsSuccess = isSuccess;
            Value = value;
        }

        public static QueryResponse<T> Success<T>(T value)
        {
            return new QueryResponse<T>(true, value);
        }

        public static QueryResponse<T> Failed<T>()
        {
            return new QueryResponse<T>(false, default(T));
        }
    }
}