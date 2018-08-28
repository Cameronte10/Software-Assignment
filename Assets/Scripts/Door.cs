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
        if (side == 0)
        {
            //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
            Vector2 fwd = transform.TransformDirection(Vector2.up);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);
            for (int i = 0; i < template.leftRooms.Length; i++)
            {
                if (hit.transform.gameObject == template.leftRooms[i])
                {
                    allowed = true;
                }
                if (hit.collider != null && template.leftRooms[i] != hit.transform.gameObject)
                {

                }
            }
            print("There is something in front of the object!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 fwd = transform.TransformDirection(Vector2.up);
        Debug.DrawRay(transform.position, fwd, Color.blue);
    }
    void FixedUpdate()
    {

    }
}
