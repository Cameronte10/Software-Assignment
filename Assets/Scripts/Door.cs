using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
    public int side;
    public RoomTemplate template;
    bool allowed = false;
    // Use this for initialization
    void Start()
    {
        template = GameObject.Find("RoomTemplate").GetComponent<RoomTemplate>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 fwd = transform.TransformDirection(Vector2.up);
        Debug.DrawRay(transform.position, fwd, Color.blue);
    }
    void FixedUpdate()
    {
        if (template.finished == true)
        {
            if (side == 0)
            {
                //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
                Vector2 fwd = transform.TransformDirection(Vector2.up);
                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 20, 12);
                Debug.Log(hit.transform.gameObject);
                for (int i = 0; i < template.leftRooms.Length - 1; i++)
                {
                    if (hit.transform.gameObject == template.leftRooms[i])
                    {
                        allowed = true;
                    }
                    if (hit.collider == null)
                    {
                        Destroy(gameObject);
                    }

                }
                if (hit.collider == null || allowed == false)
                {
                    Destroy(gameObject);
                }

            }
            if (side == 1)
            {
                //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
                Vector2 fwd = transform.TransformDirection(Vector2.up);
                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 20, 12);
                Debug.Log(hit.transform.gameObject);
                for (int i = 0; i < template.upRooms.Length - 1; i++)
                {
                    if (hit.transform.gameObject == template.upRooms[i])
                    {
                        allowed = true;
                    }
                    if (hit.collider == null)
                    {
                        Destroy(gameObject);
                    }

                }
                if (hit.collider == null || allowed == false)
                {
                    Destroy(gameObject);
                }

            }
            if (side == 2)
            {
                //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
                Vector2 fwd = transform.TransformDirection(Vector2.up);
                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 20, 12);
                Debug.Log(hit.transform.gameObject);
                for (int i = 0; i < template.rightRooms.Length - 1; i++)
                {
                    if (hit.transform.gameObject == template.rightRooms[i])
                    {
                        allowed = true;
                    }
                    if (hit.collider == null)
                    {
                        Destroy(gameObject);
                    }

                }
                if (hit.collider == null || allowed == false)
                {
                    Destroy(gameObject);
                }

            }
            if (side == 3)
            {
                //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
                Vector2 fwd = transform.TransformDirection(Vector2.up);
                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 20, 12);
                Debug.Log(hit.transform.gameObject);
                for (int i = 0; i < template.downRooms.Length - 1; i++)
                {
                    if (hit.transform.gameObject == template.downRooms[i])
                    {
                        allowed = true;
                    }
                    if (hit.collider == null)
                    {
                        Destroy(gameObject);
                    }

                }
                if (hit.collider == null || allowed == false)
                {
                    Destroy(gameObject);
                }

            }
        }
    }
}
