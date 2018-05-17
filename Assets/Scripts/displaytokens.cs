using UnityEngine;
using System.Collections;

public class displaytokens : MonoBehaviour
{
    private GUIStyle guiStyle = new GUIStyle(); //create a new variable


    void OnGUI()
    {
        guiStyle.fontSize = Screen.height / 3; //change the font size
        guiStyle.richText = true;
        var creditdisplay = PlayerPrefs.GetString("Credits");
        GUI.Label(new Rect(0, -Screen.height / 9, Screen.width, Screen.height), "<color=white>" + creditdisplay + "</color>", guiStyle);
        guiStyle.alignment = TextAnchor.MiddleCenter;



    }
}