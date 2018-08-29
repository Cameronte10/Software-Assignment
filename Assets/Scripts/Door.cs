using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool finished = false;
    public int side;
    public RoomTemplate template;
    bool allowed = false;
    public Transform lineStart;
    public Transform lineEnd;
    // Use this for initialization
    void Start()
    {
        template = GameObject.Find("RoomTemplate").GetComponent<RoomTemplate>();
        lineStart = GameObject.FindWithTag("Right").transform;
        lineEnd = gameObject.transform.Find("lineEnd");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 fwd = transform.TransformDirection(Vector2.up);
        Debug.DrawRay(transform.position, fwd, Color.blue, 20);
    }
    void FixedUpdate()
    {
        if (finished == false)
        {
            if (template.finished == true)
            {
                if (side == 0)
                {
                    //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
                    Vector2 fwd = transform.TransformDirection(Vector2.up);
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, Mathf.Infinity);
                   //RaycastHit2D hit = Physics2D.Linecast(transform.position, new Vector2(0, -20));
                    if (hit)
                    {
                        Debug.Log("HIT");
                    }

                    for (int i = 0; i < template.leftTags.Length - 1; i++)
                    {


                        if (hit && hit.transform.gameObject.CompareTag(template.leftTags[i]))
                        {
                            Debug.Log("Allowed");
                            allowed = true;
                            break;
                        }


                    }
                    if (hit == false && hit.collider == null || allowed == false)
                    {
                        Debug.Log("Deadened");
                        Destroy(gameObject);
                    }


                }
                if (side == 1)
                {
                    //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
                    Vector2 fwd = transform.TransformDirection(Vector2.up);
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, Mathf.Infinity);
                    //RaycastHit2D hit = Physics2D.Linecast(lineStart.position, lineEnd.position);

                    if (hit)
                    {
                        Debug.Log("HIT");
                    }

                    for (int i = 0; i < template.leftTags.Length - 1; i++)
                    {


                        if (hit && hit.transform.gameObject.CompareTag(template.upTags[i]))
                        {
                            Debug.Log("Allowed");
                            allowed = true;
                            break;
                        }


                    }
                    if (hit == false && hit.collider == null || allowed == false)
                    {
                        Debug.Log("Deadened");
                        Destroy(gameObject);
                    }

                }
                if (side == 2)
                {
                    //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
                    Vector2 fwd = transform.TransformDirection(Vector2.up);
                    //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, Mathf.Infinity);
                    RaycastHit2D hit = Physics2D.Linecast(lineStart.position, lineEnd.position);
                    Debug.DrawLine(lineStart.position, lineEnd.position, Color.blue);
                    if (hit)
                    {
                        Debug.Log("HIT");
                    }

                    for (int i = 0; i < template.leftTags.Length - 1; i++)
                    {


                        if (hit && hit.transform.gameObject.CompareTag(template.rightTags[i]))
                        {
                            Debug.Log("Allowed");
                            allowed = true;
                            break;
                        }


                    }
                    if (hit == false && hit.collider == null || allowed == false)
                    {
                        Debug.Log("Deadened");
                        Destroy(gameObject);
                    }

                }
                if (side == 3)
                {//raycast up if raycastinfo != template.arraySide[] delete(gameObject)
                    Vector2 fwd = transform.TransformDirection(Vector2.up);
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, Mathf.Infinity);
                    //RaycastHit2D hit = Physics2D.Linecast(transform.position, new Vector2(0, -20));
                    if (hit)
                    {
                        Debug.Log("HIT");
                    }

                    for (int i = 0; i < template.downTags.Length - 1; i++)
                    {


                        if (hit && hit.transform.gameObject.CompareTag(template.downTags[i]))
                        {
                            Debug.Log("Allowed");
                            allowed = true;
                            break;
                        }


                    }
                    if (hit == false && hit.collider == null || allowed == false)
                    {
                        Debug.Log("Deadened");
                        Destroy(gameObject);
                    }
                  
                }
                finished = true;
            }
        }
    }
}
