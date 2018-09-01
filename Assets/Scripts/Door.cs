using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //bool finished = false;
    public int side;
    public int distance;
    public RoomTemplate template;
    public Camera mainCamera;
    //bool allowed = false;
    //public Transform lineStart;
    //public Transform lineEnd;
    // Use this for initialization
    void Start()
    {
        template = GameObject.Find("RoomTemplate").GetComponent<RoomTemplate>();
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        /*lineStart = GameObject.FindWithTag("LineStart").transform;
        lineEnd = GameObject.FindWithTag("LineEnd").transform;*/
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector2 fwd = transform.TransformDirection(Vector2.up);
        Debug.DrawRay(transform.position, fwd, Color.blue, 20);*/
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (side == 0)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x - distance, collision.transform.position.y));
               //mainCamera.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x - 25, collision.transform.position.y));
            }
            if (side == 1)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x, collision.transform.position.y + distance));
                //mainCamera.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x, collision.transform.position.y + 15));
            }
            if (side == 2)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x + distance, collision.transform.position.y));
                //mainCamera.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x + 25, collision.transform.position.y));
            }
            if (side == 3)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x, collision.transform.position.y - distance));
               // mainCamera.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(collision.transform.position.x, collision.transform.position.y - 15));
            }
        }
    }
}

