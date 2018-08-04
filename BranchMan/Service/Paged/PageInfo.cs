namespace Service.Paged
{
    public sealed class PageInfo
    {
        public PageInfo(string endCursor, bool hasNextPage)
        {
            EndCursor = endCursor;
            HasNextPage = hasNextPage;
        }

        public string EndCursor { get; }
        public bool HasNextPage { get; }

        public static PageInfo NoMorePages()
        {
            return new PageInfo(string.Empty, false);
        }

        public static PageInfo HasMorePages(string endCursor)
        {
            return new PageInfo(endCursor, true);
        }
    }
}
