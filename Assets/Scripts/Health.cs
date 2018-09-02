using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public Image health1, health2, health3;
    public Player playerScript;
    public Sprite fullHealth, halfHealth, noHealth;
    private SpriteRenderer spriteRenderer;
    int currentHealth;
	// Use this for initialization
	void Start () {
        playerScript = GameObject.Find("Player").GetComponent<Player>();
        
    }
	
	// Update is called once per frame
	void Update () { //as the health deceases the health sprite images. It is set up this way so that if healing was added it would still work
        currentHealth = playerScript.health;
        if (currentHealth == 6)
        {
            health3.sprite = fullHealth;
            health2.sprite = fullHealth;
            health1.sprite = fullHealth;
        }
        if (currentHealth == 5)
        {
            health3.sprite = halfHealth;
            health2.sprite = fullHealth;
            health1.sprite = fullHealth;
        }
        if (currentHealth == 4)
        {
            health3.sprite = noHealth;
            health2.sprite = fullHealth;
            health1.sprite = fullHealth;
        }
        if (currentHealth == 3)
        {
            health3.sprite = noHealth;
            health2.sprite = halfHealth;
            health1.sprite = fullHealth;
        }
        if (currentHealth == 2)
        {
            health3.sprite = noHealth;
            health2.sprite = noHealth;
            health1.sprite = fullHealth;
        }
        if (currentHealth == 1)
        {
            health3.sprite = noHealth;
            health2.sprite = noHealth;
            health1.sprite = halfHealth;
        }
        if (currentHealth == 0)
        {
            health3.sprite = noHealth;
            health2.sprite = noHealth;
            health1.sprite = noHealth;
        }
    }
}
