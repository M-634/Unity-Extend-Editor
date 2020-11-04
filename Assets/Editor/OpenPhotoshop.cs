using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Diagnostics;
using System;

public class OpenPhotoshop : Editor
{
    const string ItemName = "Assets/Open in Photoshop";

    [MenuItem(ItemName,false)]
    static void Opne()
    {
        foreach (var guid in Selection.assetGUIDs)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var fullPath = Path.GetFullPath(path);
            Process.Start("photoshop", fullPath);
        }
    }
}
