using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmanager : MonoBehaviour
{
    public void level1()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().area = 1;
        SceneManager.LoadScene("Area1 1");
    }

    public void level2()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().area = 2;
        SceneManager.LoadScene("Area1 1");
    }
    
    public void level3()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().area = 3;
        SceneManager.LoadScene("Area1 1");
    }

    public void tutorial()
    {
        SceneManager.LoadScene("Tutorial Scene");
        GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().area = 0;
    }
}
