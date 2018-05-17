using UnityEngine;
using System.Collections;

public class MenuURL : MonoBehaviour {

	// Use this for initialization
	public void openURL () {
        Application.OpenURL("http://eat24hrs.com/restaurants/order2/menu.php?id=64753");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
