using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apator.GitHub.Interview.Helper
{
    interface IGithubClientService
    {
        /// <summary>
        /// Default: create private repository
        /// </summary>
        /// <param name="repositorySufix">Configure second part of new repository name</param>
        /// <returns></returns>
        Task CreateNewRepositoryFromTemplate(string repositorySufix);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repositorySufix">Configure second part of new repository name</param>
        /// <param name="isPrivate">Configure if new repository is private</param>
        /// <returns></returns>
        Task CreateNewRepositoryFromTemplate(string repositorySufix, bool isPrivate);
    }
}
