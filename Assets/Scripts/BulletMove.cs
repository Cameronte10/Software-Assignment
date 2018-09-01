using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;
    public float range;
    public float maxRange;
    // Use this for initialization
	void Start () {

        rb.AddForce(transform.right * speed);
	}
	
	// Update is called once per frame
    void Update () {
        
        //rb.AddForce(transform.right * speed);
        if(range >= maxRange)
        {
            Destroy(gameObject);
        }
        else{
            
            range++;
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Room"))
        {
            Destroy(gameObject);
        }
    }
}
