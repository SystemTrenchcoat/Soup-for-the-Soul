using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    int n;
    public void OnButtonPress()
    {
        if(n == 0) {
            SceneManager.LoadScene("Tutorial Scene");
            //Debug.Log("Button Pressed");
            n++;
        }
        else
        {
            SceneManager.LoadScene("AreaSelect");
        }
    }
}
