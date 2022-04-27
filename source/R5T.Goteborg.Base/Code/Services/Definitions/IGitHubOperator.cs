using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.Goteborg
{[ServiceDefinitionMarker]
    public interface IGitHubOperator:IServiceDefinition
    {
        Task<long> CreateRepository(GitHubRepository repository);
        //string GetRepositoryUrl(string repositoryName); // This does not require a GitHub! This can be determined from strings alone. Maybe a method on IGitHubUrlProvider.
        Task<bool> RepositoryExists(string owner, string name);
        Task DeleteRepository(string owner, string name);
        Task<string> GetRepositoryCheckoutUrl(string owner, string name);
        Task<string> GetRepositoryCheckoutUrl(long repositoryID);
    }
}
