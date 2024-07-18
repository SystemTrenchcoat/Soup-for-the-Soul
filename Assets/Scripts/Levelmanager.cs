using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmanager : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("Area1");
    }

    public void level2()
    {
        SceneManager.LoadScene("Area2");
    }
    
    public void level3()
    {
        SceneManager.LoadScene("Area3");
    }

    public void tutorial()
    {
        SceneManager.LoadScene("Tutorial Scene");
    }
}
