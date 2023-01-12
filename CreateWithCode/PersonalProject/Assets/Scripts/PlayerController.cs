using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody playerRb;
    private float rando;
    // Start is called before the first frame update
    void Start()
    {
      playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      Random rnd = new Random();
      for(int j=0; j < 4; j++)
      {
rando = (rnd.Next(10,20));
      }
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        
        playerRb.AddForce(Vector3.left * speed * verticalInput * -1);
        playerRb.AddForce(Vector3.forward * speed * horizontalInput);
    }
}
