using System;


namespace R5T.Goteborg
{
    public interface IGitHubOperator
    {
        void CreateRepository(GitHubRepository repository);
        //string GetRepositoryUrl(string repositoryName); // This does not require a GitHub! This can be determined from strings alone. Maybe a method on IGitHubUrlProvider.
    }
}
