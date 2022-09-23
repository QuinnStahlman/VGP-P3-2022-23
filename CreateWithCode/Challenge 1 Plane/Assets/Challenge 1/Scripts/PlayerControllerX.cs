using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        forwardInput = Input.GetAxis("Vertical");

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        transform.translate(Vector.forward * Time.deltaTime * speed * forwardInput);
    }
}
