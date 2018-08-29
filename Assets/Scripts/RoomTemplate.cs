using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplate : MonoBehaviour {
    public static RoomTemplate roomTemplate;
    public GameObject template;
    public GameObject[] leftRooms;
    public GameObject[] upRooms;
    public GameObject[] downRooms;
    public GameObject[] rightRooms;
    public bool finished = false;
    public List<GameObject> rooms;

    public float waitTime;
    public bool spawnedBoss;
    public GameObject boss;

    private void Update()
    {
        if (waitTime >= 3)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == rooms.Count-1 && spawnedBoss == false)
                {
                    finished = true;
                    spawnedBoss = true;
                    Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
                }
            }
        }
        else 
        {
            waitTime += 1 * Time.deltaTime;
        }
    }
}
