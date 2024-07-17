using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Tutorial Scene");
        Debug.Log("Button Pressed");
    }
}
