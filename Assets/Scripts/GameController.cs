using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown(KeyCode.Escape))//hitting escape loads the main menu
        {
            MainMenu();
        }

       
	}
    
    void SpawnEnemies()
    {
       //no longer using this
        Vector3 pos3D = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
        
        //spawnPos.position = pos2D;
        GameObject enemyPrefab = enemy[Random.Range(0, enemy.Length)];
        //enemyPrefab.transform.position = pos2D;
        Instantiate(enemyPrefab, pos3D, gameObject.transform.rotation);
    }

    void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
