using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public double popularity = 0;
    public double points = 0;
    public float levelTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().name == "Area1 1")
        {
            levelTimer -= Time.deltaTime;
            //Debug.Log(Time.deltaTime);
            //Debug.Log(levelTimer);
            //Debug.Log(name);

            if (levelTimer < 0)
            {
                Debug.Log("Leave");
                SceneManager.LoadScene("AreaSelect");//"Point System");
            }
        }
    }
}
