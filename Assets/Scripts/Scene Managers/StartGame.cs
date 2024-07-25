using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public static int i;

    public void Begin()
    {
        if (i == 0)
        {
            SceneManager.LoadScene("Tutorial Scene");
            Debug.Log("Button Pressed");
            i++;
            Debug.Log(i);
        }
        else
        {
            SceneManager.LoadScene("AreaSelect");
        }
    }
}
