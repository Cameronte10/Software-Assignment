using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public Rigidbody2D rb2D;
    public float maxSpeed;
    public float speed;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.W))
        {
            rb2D.AddForce(transform.up * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb2D.AddForce(-transform.up * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2D.AddForce(-transform.right * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2D.AddForce(transform.right * speed);
        }
    }
}
