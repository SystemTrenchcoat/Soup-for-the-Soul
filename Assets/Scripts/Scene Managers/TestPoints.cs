using UnityEngine;

public class TestPoints : MonoBehaviour
{
    public PointManager pointManager; // Reference to the PointManager script

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pointManager.AddPoints(10);
        }
    }
}
