using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_bh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);

    }

    //when player collides with coin, destroy coin
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //add a coin
            other.gameObject.GetComponent<player_controler>().coins += 1;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
}
