using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controler : MonoBehaviour
{
    public GameObject bullet;
    public GameObject trigger;
    public int lives = 3;
    public GameObject loader;
    public int coins = 0;
    public GameObject hook;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-0.2f, -0.168f, 1);
        lives = 3;
        coins = 0;

    }

    // Update is called once per frame
    private bool posision = false;
    private float _timer = 0f;
    void Update()
    {
        
        _timer += Time.deltaTime;
        //move character left with a and right with d exactly 0.347 units per frame
        if (Input.GetKey(KeyCode.A) && posision)
        {
            posision = false;
            transform.position += new Vector3(0, -0.347f, 0);
  
        }
        if (Input.GetKey(KeyCode.D) && !posision)
        {
            posision = true;
            transform.position += new Vector3(0, 0.347f, 0);

        }
        
        //when left mouse button is pressed, shoot a bullet using trigger's transform
        if (Input.GetMouseButtonDown(0) && _timer >= 2/3f)  
        {
            _timer = 0f;
            Instantiate(loader, new Vector3(-0.757f, 0, 0), Quaternion.Euler(0,0,90));
            Instantiate(bullet, trigger.transform.position, Quaternion.identity);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(hook, transform.position, Quaternion.Euler(0,0,90));
            
        }

        //if lives are 0, destroy player
        if (lives <= 0)
        {
            Destroy(gameObject);
        }
     
        
    }
}
