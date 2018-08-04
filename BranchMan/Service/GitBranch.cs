using System;

namespace Service
{
    public class GitBranch
    {
        /// <summary>
        /// The repository this branch belongs to.
        /// </summary>
        public GitRepository OwningGitRepository { get; }
        /// <summary>
        /// The date and time the branch was last committed to in UTC.
        /// </summary>
        public DateTime LastCommittedTo { get; }
    }
}