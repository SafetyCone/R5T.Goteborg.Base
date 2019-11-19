using System;


namespace R5T.Goteborg
{
    public class GitHubRepository
    {
        #region Static

        public static GitHubRepository GetDefault(string name, string description)
        {
            var gitHubRepository = new GitHubRepository()
            {
                Name = name,
                Description = description,
                Visibility = GitHubRepositoryVisibility.Public,
                InitializeWithReadMe = true,
                License = GitHubRepositoryLicense.MIT,
            };

            return gitHubRepository;
        }

        #endregion


        public string Name { get; set; }
        public string Description { get; set; }

        public GitHubRepositoryVisibility Visibility { get; set; }
        public bool InitializeWithReadMe { get; set; }
        public GitHubRepositoryLicense License { get; set; }
    }
}
