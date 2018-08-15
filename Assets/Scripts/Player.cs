using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public static Player instance;
    public Rigidbody2D rb2D;
    public float maxSpeed;
    public float speed;
    public float bulletDamage;

    public GameObject bullet;
    public float delay;
    public float delayMax;

    Quaternion rotation;

   
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
        Shoot();
    }

    void Shoot()
    {
        delay++;
        //delay += Time.deltaTime;
        if (delay >= delayMax)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rotation = Quaternion.Euler(0, 0, 90);
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), rotation);
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                rotation = Quaternion.Euler(0, 0, -90);
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), rotation);
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rotation = Quaternion.Euler(0, 0, 0);
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), rotation);
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                rotation = Quaternion.Euler(0, 0, 180);
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), rotation);
                delay = 0;
            }

        }
    }

}
