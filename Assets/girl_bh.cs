using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl_bh : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.4f;

    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move in x axis by it self
        transform.position += new Vector3(-1 * speed, 0, 0);

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered");
        if (other.gameObject.CompareTag("Player"))
        {   
            //recude a life
            player.GetComponent<player_controler>().lives -= 1;
            Debug.Log("triggered");
            Destroy(gameObject);
        }else if (other.gameObject.CompareTag("Bullet"))
        {
            //destroy bullet
            Destroy(other.gameObject);
            //destroy enemy
            int coin_chace = Random.Range(1, 3);
            if (coin_chace == 1)
            {
                Instantiate(coin, transform.position, Quaternion.Euler(0,0,90));
            }
            
            Destroy(gameObject);
        }
    }   
}
