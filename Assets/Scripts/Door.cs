using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int side;
    public int distance;
    public Camera mainCamera;
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))//if it collides with the player and teleport it, based on the direction, to the next room 
        {
            if (side == 0)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x - distance, collision.transform.position.y));
              
            }
            if (side == 1)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x, collision.transform.position.y + distance));
                
            }
            if (side == 2)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x + distance, collision.transform.position.y));
               
            }
            if (side == 3)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x, collision.transform.position.y - distance));
               
            }
        }
    }
}

