using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public float xMin;
    public float xMax;

    public float yMin;
    public float yMax;

    public GameObject[] enemy;
    //public Transform spawnPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnEnemies();
        }
	}
    
    void SpawnEnemies()
    {
        //not working yet
        Vector3 pos3D = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
        
        //spawnPos.position = pos2D;
        GameObject enemyPrefab = enemy[Random.Range(0, enemy.Length)];
        //enemyPrefab.transform.position = pos2D;
        Instantiate(enemyPrefab, pos3D, gameObject.transform.rotation);
    }
}
