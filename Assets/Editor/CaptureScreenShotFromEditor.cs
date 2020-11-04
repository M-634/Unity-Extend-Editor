using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CaptureScreenShotFromEditor : Editor
{
    /// <summary>
    /// ゲームビューをスクリーンショットする
    /// メニューバー ＞ M-634　＞CaptureScreenShotを押してください
    /// ショートカットキーはshift + p
    /// </summary>
   [MenuItem("M-634/CaptureScreenShot #p")]
    private static void ScreenShot()
    {
        string path = EditorUtility.SaveFilePanel("Save Screenshot",
            Application.dataPath, System.DateTime.Now.ToString("yyyyMMdd-HHmmss"), "png");

        ScreenCapture.CaptureScreenshot(path);
        var assembly = typeof(EditorWindow).Assembly;
        var type = assembly.GetType("UnityEditor.GameView");
        var gameview = EditorWindow.GetWindow(type);
        gameview.Repaint();
        Debug.Log("ScreenShot: " + path);
    }
}
