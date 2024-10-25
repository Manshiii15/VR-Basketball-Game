using UnityEngine;

public class BallBounceSound : MonoBehaviour
{
    public AudioSource bounceSound;  // Reference to the AudioSource
    public string groundTag = "Ground";  // Tag for the ground object

    void Start()
    {
        bounceSound = GetComponent<AudioSource>();  // Get the AudioSource attached to the ball
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object the ball collided with has the "Ground" tag
        if (collision.gameObject.CompareTag(groundTag) && collision.relativeVelocity.magnitude > 1f)
        {
            bounceSound.Play();  // Play the bounce sound
        }
    }
}
