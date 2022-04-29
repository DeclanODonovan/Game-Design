using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Final_Player : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool moveRight = false;
    private bool moveLeft = false;
    private float Acceleration = 5;
    public int time = 0;
    private bool laser = false;
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveRight = ((Input.GetKey(KeyCode.A)));
        if (moveRight)
        {
            Acceleration += 1;
        }
        moveLeft = ((Input.GetKey(KeyCode.D)));
        if (moveLeft)
        {
            Acceleration += 1;
        }
        time += 1;

        laser = (Input.GetKey(KeyCode.Space));
        if (laser)
        {
            Instantiate(prefab, new Vector3(this.transform.position.x, (this.transform.position.y + 2), this.transform.position.z) , Quaternion.identity); 
        }
    }

    void FixedUpdate()
    {
        if (moveRight)
        {
            rb.velocity = new Vector3(-2 * Acceleration, 0, 0);
            if (time == 5)
            {
                rb.velocity = new Vector3(0, 0, 0);
                time = 0;
            }
        }
        Acceleration = 5;
        if (moveLeft)
        {
            rb.velocity = new Vector3(2 * Acceleration, 0, 0);
            if (time == 5)
            {
                Debug.Log("time");
                rb.velocity = new Vector3(0, 0, 0);
                time = 0;
            }
        }
        Acceleration = 5;
    }
   
}
