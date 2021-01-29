using UnityEditor;
using UnityEngine;

namespace BuildTools
{
    partial class BuildToolsEditorWindow
    {
        private void ListCleanUtility()
        {
            if (GUILayout.Button("Clean Player Prefs"))
            {
                CleanPlayerPrefs();
            }
            if (GUILayout.Button("Clean Addressables Build"))
            {
                CleanAddressablesBuild();
            }
            if (GUILayout.Button("Clean Build Folder"))
            {
                CleanBuildFolder();
            }
        }

        private void CleanPlayerPrefs()
        {
            Debug.Log(BuildToolsUtils.logLabel + "Cleaning Player Prefs");
            PlayerPrefs.DeleteAll();
        }

        private void CleanAddressablesBuild()
        {
            Debug.Log(BuildToolsUtils.logLabel + "Cleaning Addressables Build");
            UnityEditor.AddressableAssets.Settings.AddressableAssetSettings.CleanPlayerContent();
        }

        private void CleanBuildFolder()
        {
            Debug.Log(BuildToolsUtils.logLabel + "Cleaning Build Folder");
            FileUtil.DeleteFileOrDirectory(BuildToolsUtils.buildPathRoot);
        }
    }
}
