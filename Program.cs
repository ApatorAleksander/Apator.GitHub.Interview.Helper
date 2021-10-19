using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace Apator.GitHub.Interview.Helper
{
    class Program
    {
        public static void Main()
        {
            Task.WaitAll(ExecuteAsync());
        }

        public static async Task ExecuteAsync()
        {
            IGithubClientService githubClientService = new GitHubClientService("ApatorAleksander","Apator.Interview");
            await githubClientService.CreateNewRepositoryFromTemplate("Test");
            await githubClientService.DeleteGitFiles($".gitignore", "Test");
        }
    }
}
