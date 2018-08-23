using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {
    public GameObject[] rooms;
    public int currentRoomSide; //0 left, 1 up, 2 right, 3 down
    public int random;
    public int collisionCount;
    public RoomTemplate template;
    public bool spawned = false;
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spawnpoint"))
        {
            if (collision.gameObject.GetComponent<Spawnpoint>().spawned == false && spawned == false)
            {
                //Instantiate(); make room close off 
                Destroy(gameObject);
            }
            spawned = true;
        }
    }

    void Start () {
        template = GameObject.Find("RoomTemplate").GetComponent<RoomTemplate>();
        Invoke("Spawn", 0.01f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        if(spawned == false)
        {
            if (currentRoomSide == 0)
            {
                random = (int)Random.Range(0, 8);
                Instantiate(template.leftRooms[random], transform.position, transform.rotation);
            }
            if (currentRoomSide == 1)
            {
                random = (int)Random.Range(0, 8);
                Instantiate(template.upRooms[random], transform.position, transform.rotation);
            }
            if (currentRoomSide == 2)
            {
                random = (int)Random.Range(0, 8);
                Instantiate(template.rightRooms[random], transform.position, transform.rotation);
            }
            if (currentRoomSide == 3)
            {
                random = (int)Random.Range(0, 8);
                Instantiate(template.downRooms[random], transform.position, transform.rotation);
            }
            spawned = true;
        }
    }
    
    
}
