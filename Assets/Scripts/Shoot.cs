using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
    Quaternion rotation;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rotation = Quaternion.Euler(0, 0, 0);
            Instantiate(bullet, transform.position, rotation); 
        }
	}
}
