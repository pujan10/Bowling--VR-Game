using UnityEngine;

public class PinCollision : MonoBehaviour
{
    // Tag your bowling ball as "Ball" in Unity for easier identification
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the bowling ball
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log(gameObject.name + " hit by ball!");

        }
    }
}
