using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apator.GitHub.Interview.Helper.Octokit.Models
{
    public static class ApatorApiUrls
    {
        public static Uri Repositories(string owner, string repo)
        {
            return "repos/{0}/{1}/generate".FormatUri(owner, repo);
        }

        public static Uri FormatUri(this string pattern, params object[] args)
        {
            if (pattern is not null)
            {
                return new Uri(string.Format(CultureInfo.InvariantCulture, pattern, args), UriKind.Relative);
            }
            return null;
        }
    }
}
