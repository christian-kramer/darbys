using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TokenScene : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(3);
        }
    }
}

