using System;


namespace R5T.Goteborg
{
    public class GitHubRepository
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public GitHubRepositoryVisibility Visibility { get; set; }
        public bool InitializeWithReadMe { get; set; }
        public GitHubRepositoryLicense License { get; set; }
    }
}
