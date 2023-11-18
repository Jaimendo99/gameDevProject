using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook_bh : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move in x axis by it self
        transform.position += new Vector3(speed, 0, 0);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
           // every time the hook hits something, it moves to the player position
           Vector3 playerPosition = player.transform.position;
           other.transform.position = playerPosition;

    }
}
