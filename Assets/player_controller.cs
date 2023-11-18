using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private bool posision = false;
    void Update()
    {
        
        //move character left with a and right with d exactly 0.347 units per frame
        if (Input.GetKey(KeyCode.A) && posision == true)
        {
            posision = false;
            transform.position += new Vector3(-0.347f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) && posision == false)
        {
            posision = true;
            transform.position += new Vector3(0.347f, 0, 0);
        }
        
    }
}
