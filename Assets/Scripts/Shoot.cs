using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bullet;
    public float delay;
    public float delayMax;
    // Use this for initialization
	void Start () {
		
	}
    Quaternion rotation;
	// Update is called once per frame
	void Update () {
        delay++;
        //delay += Time.deltaTime;
        if (delay >= delayMax)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rotation = Quaternion.Euler(0, 0, 90);
                Instantiate(bullet, transform.position, rotation);
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                rotation = Quaternion.Euler(0, 0, -90);
                Instantiate(bullet, transform.position, rotation);
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rotation = Quaternion.Euler(0, 0, 0);
                Instantiate(bullet, transform.position, rotation);
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                rotation = Quaternion.Euler(0, 0, 180);
                Instantiate(bullet, transform.position, rotation);
                delay = 0;
            }
               
        }
	}
}
