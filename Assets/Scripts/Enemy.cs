﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public static Enemy enemyScript;
    public Transform target;
    public float speed;
    public int health;
    public int damage;
    public float radius = 7f;
    public bool isBoss = false;
    // Use this for initialization
    void Start()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
        enemy = GameObject.Find("Enemy");
        enemyScript = this;
        
    }

    // Update is called once per frame
    void Update()
    {


        //transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), new Vector2 (target.position.x, target.position.y), speed);
        if (isBoss == true && health <= 0)
        {
            SceneManager.LoadScene(3);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        Collider2D results = Physics2D.OverlapCircle(transform.position, radius);
        
        if (results.gameObject.CompareTag("Player"))
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), new Vector2(target.position.x, target.position.y), speed);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= Player.playerScript.bulletDamage;
            //Debug.Log(Player.playerScript.bulletDamage);
            Destroy(collision.gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Color c = new Color(0, 1, 0, 0.3f);
        Gizmos.color = c;
        
        Gizmos.DrawSphere(transform.position, radius);
    }
}
