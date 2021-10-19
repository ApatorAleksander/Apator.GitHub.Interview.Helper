using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apator.GitHub.Interview.Helper.Octokit.Models;
using Octokit;
using Octokit.Reactive;

namespace Apator.GitHub.Interview.Helper
{
    class GitHubClientService : IGithubClientService
    {
        private static readonly IGitHubClient client = new GitHubClient(new ProductHeaderValue("Apator.Github.Interview.Helper"))
        {
            Credentials = new Credentials("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")
        };
        private readonly ApiConnection apiConnection;
        private readonly string owner;
        private readonly string newRepositoryBase;
        public GitHubClientService(string owner, string newRepositoryBase)
        {
            this.apiConnection = new ApiConnection(client.Connection);
            this.owner = owner;
            this.newRepositoryBase = newRepositoryBase;
        }

        public async Task CreateNewRepositoryFromTemplate(string repositorySufix)
        {
            var newRepository = new NewRepositoryFromTemplate($"{newRepositoryBase}.{repositorySufix}");
            newRepository.Private = true;
            var uri = ApatorApiUrls.Repositories($"{owner}", "Apator.GitHub.Interview.Helper");
            await apiConnection.Post<Repository>(uri, newRepository, ApatorAcceptHeaders.TemplatePreview);
        }

        public async Task CreateNewRepositoryFromTemplate(string repositorySufix, bool isPrivate)
        {
            var newRepository = new NewRepositoryFromTemplate($"{newRepositoryBase}.{repositorySufix}");
            newRepository.Private = isPrivate;
            var uri = ApatorApiUrls.Repositories($"{owner}", "Apator.GitHub.Interview.Helper");
            await apiConnection.Post<Repository>(uri, newRepository, ApatorAcceptHeaders.TemplatePreview);
        }
    }
}