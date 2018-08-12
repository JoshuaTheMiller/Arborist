using System;

namespace Arborist.Contracts
{
    public sealed class User
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }

        public static User Create(string id, string displayName)
        {
            return new User
            {
                Id = id,
                DisplayName = displayName
            };
        }

        public static User None()
        {
            return new User
            {
                Id = string.Empty,
                DisplayName = string.Empty
            };
        }
    }
}
