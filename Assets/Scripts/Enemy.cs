using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform target;
    public float speed;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target.position, speed);
	}


     void OnCollisionEnter(Collision collision)
	{
        if(collision.gameObject.tag == "Bullet"){
            Debug.Log("Potato");
            Destroy(gameObject);

        }
	}
}
