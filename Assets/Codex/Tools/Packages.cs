using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace Codex.Tools
{
    public static class Packages
    {
        private static string GetGistUrl(string id, string user = "SuperGent") =>
            $"https://gist.githubusercontent.com/{user}/{id}/raw";

        private static async Task<string> GetContents(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            return content;
        }

        public static void ReplacePackageFile(string id, string user = "SuperGent")
        {
            var contents = GetContents(GetGistUrl(id, user));
            var existing = Path.Combine(Application.dataPath, "../Packages/manifest.json");
            
            UnityEditor.PackageManager.Client.Resolve();
        }

        public static void InstallUnityPackage(string packageName)
        {
            UnityEditor.PackageManager.Client.Add($"$com.unity.{packageName}");
        }
    }
}