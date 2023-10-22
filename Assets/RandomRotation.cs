using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    void Start()
    {
        // Generate a random rotation angle between 0 and 360 degrees.
        float randomRotationAngle = Random.Range(0f, 360f);

        // Create a Quaternion representing the rotation around the Z axis.
        Quaternion randomRotation = Quaternion.Euler(randomRotationAngle, 0, 0f);

        // Apply the rotation to the object.
        transform.rotation = randomRotation;
    }
}
