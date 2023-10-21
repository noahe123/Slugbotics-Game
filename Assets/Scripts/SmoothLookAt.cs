using UnityEngine;

public class SmoothLookAt : MonoBehaviour
{
    public Transform player; // The player's Transform

    public float rotationSpeed = 5.0f; // Adjust this for the speed of rotation

    private void FixedUpdate()
    {
        if (player != null)
        {
            // Calculate the direction from the object to the player
            Vector3 directionToPlayer = player.position - transform.position;

            // Calculate the rotation that looks at the player
            Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);

            // Smoothly interpolate the current rotation to the target rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
