using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTutorial : MonoBehaviour
{
    public void finished()
    {
        SceneManager.LoadScene("AreaSelect");
    }
}
