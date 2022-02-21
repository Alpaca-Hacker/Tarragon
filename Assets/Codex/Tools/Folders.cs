using System.IO;
using UnityEngine;

namespace Codex.Tools
{
    public static class Folders
    {
        public static void Create(string root, params string[] dirs)
        {
            foreach (var dir in dirs)
            {
                Directory.CreateDirectory(Path.Combine(Application.dataPath, root, dir));
            }
        }
    }
}