using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player playerScript; //leave this out
    public GameObject player; //Get player GameObject
    public Rigidbody2D rb2D; //Get player RigidBody2D
    //public float maxSpeed;
    public float speed; //How fast player moves
    public int bulletDamage = 1; //sets bullet damage
    public int health = 6; //Health of the player
    public GameObject bullet; //Get Bullet GameObject for shooting
    public float delay; //Shoot delay Timer
    public float delayMax; //Shoot delay Timer
    float eDelay = 2;
    float eDelayMax = 0.75f;
    Quaternion rotation; //Rotation of the bullet
    public Animator animator;
    public bool beingAttacked;
    // Use this for initialization
    void Start() //runs on the first frame
    {
        player = GameObject.Find("Player"); //Finds the Player in game
        playerScript = player.GetComponent<Player>(); //gets the Player script in the player Objects
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() //runs every frame
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(3); //load lose screen
        }
        if (Input.GetKey(KeyCode.W)) //on key press do:
        {
            animator.SetBool("isUp", true);
            animator.SetBool("isDown", false);
            animator.SetBool("isRight", false);
            animator.SetBool("isLeft", false);
            rb2D.AddForce(transform.up * speed); //move direction
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isUp", false);
            animator.SetBool("isDown", true);
            animator.SetBool("isRight", false);
            animator.SetBool("isLeft", false);
            rb2D.AddForce(-transform.up * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isUp", false);
            animator.SetBool("isDown", false);
            animator.SetBool("isRight", false);
            animator.SetBool("isLeft", true);
            rb2D.AddForce(-transform.right * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2D.AddForce(transform.right * speed);
            animator.SetBool("isUp", false);
            animator.SetBool("isDown", false);
            animator.SetBool("isRight", true);
            animator.SetBool("isLeft", false);
        }
        if (beingAttacked == true && eDelay > eDelayMax)//allows the enemy to repeatedly hit you
        {
            eDelay = 0;
            health -= Enemy.enemyScript.damage;
        }
        Shoot();//Call shoot function
        eDelay += 1 * Time.deltaTime;
    }

    void Shoot()
    {
        delay += 10 * Time.deltaTime;//delay for shooting increment
        if (delay >= delayMax)//If delay greater than max
        {
            if (Input.GetKey(KeyCode.UpArrow))//input
            {
                rotation = Quaternion.Euler(0, 0, 90);
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), rotation);//spawns bullet at the right direction
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                rotation = Quaternion.Euler(0, 0, -90);
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), rotation);
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rotation = Quaternion.Euler(0, 0, 0);
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), rotation);
                delay = 0;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                rotation = Quaternion.Euler(0, 0, 180);
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), rotation);
                delay = 0;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))//if hit by by enemy 
        {
            beingAttacked = true;
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        beingAttacked = false;
    }
}
