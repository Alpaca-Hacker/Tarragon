using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Codex.Tools
{
    public static class ToolMenu 
    {
        [MenuItem("Tools/Codex/Setup/Create Default Folders")]
        private static void CreateDefaultFolders()
        {
            Folders.Create("_Project", "Scenes", "Art/Prefabs", "Art/Audio", "Art/Fonts", "Art/Sprites", "Art/Animations");
            Folders.Create("_Project", "Scripts/Main", "Scripts/Managers", "Scripts/Utils");
            
            AssetDatabase.Refresh();
        }

        [MenuItem("Tools/Codex/Setup/Replace Packages")]
        private static void ReplacePackageManifest()
        {
            Packages.ReplacePackageFile("ddfaa5c750caeca07249ba018cfd7023");
        }

        //Extend as required
        [MenuItem("Tools/Codex/Setup/Packages/New Input System")]
        private static void AddNewInputSystem() => Packages.InstallUnityPackage("inputsystem");
    }
}
