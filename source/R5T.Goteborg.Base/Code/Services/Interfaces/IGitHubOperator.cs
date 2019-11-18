using System;


namespace R5T.Goteborg
{
    public interface IGitHubOperator
    {
        void CreateRepository(GitHubRepository repository);
        string GetRepositoryUrl(string repositoryName);
    }
}
