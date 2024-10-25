using UnityEngine;

public class BallThrowDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the paper ball
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Basket ball entered the basket!");
            // Call scoring function or any other action
            ScorePoint();
        }
    }

    void ScorePoint()
    {
        // Implement your scoring logic here
        Debug.Log("Scored a point!");
    }
}