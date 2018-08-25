using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public int side;
    public RoomTemplate template;
	// Use this for initialization
	void Start () {
		if(side == 0)
        {
            //raycast up if raycastinfo != template.arraySide[] delete(gameObject)
            Vector2 fwd = transform.TransformDirection(Vector2.up);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);
            if (hit.collider != null && hit.transform.gameObject.CompareTag("Room") && )
            {
                
            }
                print("There is something in front of the object!");
        }
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 fwd = transform.TransformDirection(Vector2.up);
        Debug.DrawRay(transform.position, fwd, Color.blue);
	}
    void FixedUpdate()
    {

    }
}
