using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(gameObject, 2/3f);
    }

    // Update is called once per frame
    void Update()
    {
        //desrtoy loading screen after 1 second
    }
}
