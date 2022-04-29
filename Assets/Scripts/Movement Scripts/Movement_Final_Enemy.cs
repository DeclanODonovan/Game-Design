using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement_Final_Enemy : MonoBehaviour
{
    
    public Rigidbody2D rb;
    private bool moveRight = false;
    private bool moveLeft = false;
    private float Acceleration = 5;
    private int direction = 0;
    public int pattern = 0;
    public int shoot = 0;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {

        pattern = Random.Range(0, 80);
        shoot = Random.Range(0, 50);
        if (pattern == 1)
        {
            moveRight = true;
            moveLeft = false;
        }
        if (pattern == 2)
        {
            moveLeft = true;
            moveRight = false;
        }


        if (shoot == 1)
        {
            Instantiate(prefab, new Vector3(this.transform.position.x, (this.transform.position.y -3), this.transform.position.z), Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        if (moveRight)
        {
            rb.velocity = new Vector3(2 * Acceleration, 0, 0);
            //moveLeft = false;
        }
        Acceleration = 5;
        if (moveLeft)
        {
            rb.velocity = new Vector3(-2 * Acceleration, 0, 0);
            //moveRight = false;
        }
        Acceleration = 5;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Left Wall")
        {
            moveRight = true;
            moveLeft = false;
            Debug.Log("left");
        }
        if (collision.gameObject.tag == "Right Wall")
        {
            moveLeft = true;
            moveRight = false;
            Debug.Log("right");
        }
    }
}
