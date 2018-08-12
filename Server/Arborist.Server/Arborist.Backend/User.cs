namespace Arborist.Backend
{
    public sealed class User
    {
        public UserIdentifier Id { get; private set; }
        public string DisplayName { get; private set; }

        public static User Invalid()
        {
            return new User
            {
                DisplayName = string.Empty,
                Id = UserIdentifier.Invalid()
            };
        }

        public static User CreateWithStringId(string displayName, string id)
        {
            return new User
            {
                Id = UserIdentifier.CreateFromString(id),
                DisplayName = displayName
            };
        }
    }
}