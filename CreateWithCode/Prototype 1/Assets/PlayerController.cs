using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //Move the vehicle forward
       transform.Translate(Vector3.forward); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
