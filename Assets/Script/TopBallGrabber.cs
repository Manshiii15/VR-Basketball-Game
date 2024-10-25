using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Linq;

public class TopBallGrabber : MonoBehaviour
{
    public LayerMask ballLayerMask;   // Layer mask for balls
    public float raycastDistance = 5.0f; // Adjust distance as needed
    public Transform handTransform;   // Controller/hand transform to cast the ray from

    private XRGrabInteractable topBallInteractable = null;  // Store the current top ball

    void Update()
    {
        // Find all colliders in the ballLayerMask within a certain distance from the hand/controller
        Collider[] ballColliders = Physics.OverlapSphere(handTransform.position, raycastDistance, ballLayerMask);

        if (ballColliders.Length > 0)
        {
            // Find the topmost ball by Y position (or closest if you prefer)
            Collider topBall = ballColliders.OrderByDescending(c => c.transform.position.y).First();

            XRGrabInteractable interactable = topBall.GetComponent<XRGrabInteractable>();

            if (interactable != null && interactable != topBallInteractable)
            {
                // Disable grabbing for the previously top ball
                if (topBallInteractable != null)
                {
                    topBallInteractable.interactionLayerMask = 0; // Disable interaction
                }

                // Enable grabbing for the current top ball
                interactable.interactionLayerMask = LayerMask.GetMask("Default"); // Enable interaction
                topBallInteractable = interactable;
            }
        }
    }
}
