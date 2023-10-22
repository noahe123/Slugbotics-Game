using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed

    public float rotationSpeed = 5f;

    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed;

        //rotate roomba towards direction
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, -movement, Time.deltaTime * rotationSpeed, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);

        // Apply the movement to the Rigidbody
        rb.velocity = movement;
    }
}
