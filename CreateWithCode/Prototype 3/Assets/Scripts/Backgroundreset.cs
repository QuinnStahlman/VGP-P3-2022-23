using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundreset : MonoBehaviour
{
    public GameObject backgroundPrefab;
    private Vector3 spawnPos = new Vector3(45, 10, 4);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController PlayerController;
    // Start is called before the first frame update
    void Start()
    {PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
       InvokeRepeating( "Spawnbackground", startDelay, repeatRate);
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnbackground(){

       if(PlayerController.gameOver == false){  
        Instantiate(backgroundPrefab, spawnPos, backgroundPrefab.transform.rotation);
       }
    }
}
