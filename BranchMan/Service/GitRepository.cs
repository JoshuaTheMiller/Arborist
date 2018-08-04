using System;

namespace Service
{
    public sealed class GitRepository
    {
        /// <summary>
        /// The name of the repository.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The browsible location of the repository.
        /// </summary>
        public Uri Location { get; }
    }
}