namespace Arborist.Backend
{
    public sealed class UserIdentifier
    {
        public string Id { get; private set; }

        public override string ToString()
        {
            return Id;
        }        

        internal static UserIdentifier Invalid()
        {
            return new UserIdentifier
            {
                Id = string.Empty
            };
        }

        internal static UserIdentifier CreateFromString(string id)
        {
            return new UserIdentifier
            {
                Id = id
            };
        }
    }
}