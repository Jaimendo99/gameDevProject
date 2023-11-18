using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_bh : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             
            //move in x axis by it self
            transform.position += new Vector3(speed, 0, 0);
        //if bullet is out of screen, destroy it
        if (transform.position.x > 1)
        {
            Destroy(gameObject);
        }
    }
    
}
