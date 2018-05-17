using UnityEngine;
using System.Collections;

public class ErrorDisplay : MonoBehaviour {

    private GUIStyle guiStyle = new GUIStyle(); //create a new variable

    void OnGUI()
    {
        guiStyle.fontSize = Screen.height / 40; //change the font size
        guiStyle.richText = true;
        var errordisplay = PlayerPrefs.GetString("Error Display");
        GUI.Label(new Rect(0, 40, Screen.width, Screen.height), "<color=white>" + errordisplay + "</color>", guiStyle);
        guiStyle.alignment = TextAnchor.MiddleCenter;



    }
}
