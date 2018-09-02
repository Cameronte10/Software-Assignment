using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public static Enemy enemyScript;
    public Transform target;
    public float speed;
    public int health;
    public int damage;
    public float radius = 5f;
    public bool isBoss = false;
    public Animator animator;
    public Slider healthBar;
    public int bossDistance = 0;
    public AudioSource audioSource;
    public AudioSource BG;
    public AudioClip Boss;
    // Use this for initialization
    void Start()
    {
        healthBar.gameObject.SetActive(false);
        target = GameObject.Find("Player").GetComponent<Transform>();
        enemy = GameObject.Find("Enemy");
        enemyScript = this;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (isBoss == true && health <= 0)//takes you to win screen
        {
            SceneManager.LoadScene(2);
        }
        if (health <= 0)//destroys normal enemys
        {
            Destroy(gameObject);
        }
        Collider2D results = Physics2D.OverlapCircle(transform.position, radius);//creates a sphere that checks for collisions and spits them into the results
        
        if (results.gameObject.CompareTag("Player"))//checks results for a player collision
        {
            if (isBoss)//if this is the boss
            {
                BG.clip = Boss;
                if (!BG.isPlaying)
                {
                    BG.Play();
                }
                
                healthBar.gameObject.SetActive(true);//activates health bar on screen
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), new Vector2(target.position.x, target.position.y + bossDistance), speed);//since the boss is bigger its middle is not in the collider. I had to offset it so that it could attack the player
            }

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            
            
            else
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), new Vector2(target.position.x, target.position.y), speed);//normal enemy movement

            }
            if (isBoss)
            {
                if (target.position.x < transform.position.x)//animations for left
                {
                    animator.SetBool("isRight", false);
                    animator.SetBool("isLeft", true);
                    animator.SetBool("isUp", false);
                    animator.SetBool("isDown", false);
                   
                }
                if (target.position.x > transform.position.x)//animations for right
                {
                    animator.SetBool("isRight", true);
                    animator.SetBool("isLeft", false);
                    animator.SetBool("isUp", false);
                    animator.SetBool("isDown", false);
                   
                }
            }
            else
            {
                if (target.position.x < transform.position.x)//animations for left
                {
                    animator.SetBool("isRight", false);
                    animator.SetBool("isLeft", true);
                    animator.SetBool("isUp", false);
                    animator.SetBool("isDown", false);
                }
                if (target.position.x > transform.position.x)//animations for right
                {
                    animator.SetBool("isRight", true);
                    animator.SetBool("isLeft", false);
                    animator.SetBool("isUp", false);
                    animator.SetBool("isDown", false);
                }
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))//take damage if hit by bullet
        {
            health -= Player.playerScript.bulletDamage;
            if (isBoss)
            {
                healthBar.value -= Player.playerScript.bulletDamage;
            }
            //Debug.Log(Player.playerScript.bulletDamage);
            Destroy(collision.gameObject);
        }
    }

    private void OnDrawGizmos()//this allows me to see the OverlapCircle in the scene view
    {
        Color c = new Color(0, 1, 0, 0.3f);
        Gizmos.color = c;
        
        Gizmos.DrawSphere(transform.position, radius);
    }
}
