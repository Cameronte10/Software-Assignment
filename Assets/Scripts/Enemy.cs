using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform target;
    public float speed;
    public float health;
	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target.position, speed);
            if(health <= 0)
        {
            Destroy(gameObject);
        }
    }


     void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.CompareTag("Bullet")){
            Debug.Log("Potato");
            Destroy(collision.gameObject);
            health -= Player.instance.bulletDamage;

        }
	}
}
