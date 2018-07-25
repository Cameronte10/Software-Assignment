using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.right * speed);
	}
}
