using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public static Enemy enemyScript;
    public Transform target;
    public float speed;
    public int health;
    public int damage;
    //public float bulletDamage = Player.instance.bulletDamage;
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
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target.position, speed);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= Player.playerScript.bulletDamage;
            Debug.Log(Player.playerScript.bulletDamage);
            Destroy(collision.gameObject);
        }
    }

}
