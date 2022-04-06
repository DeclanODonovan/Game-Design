using UnityEngine;
using System.Collections;

// The velocity along the y axis is 10 units per second.  If the GameObject starts at (0,0,0) then
// it will reach (0,100,0) units after 10 seconds.

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;

    private float time = 0.0f;
    private bool isMoving = false;
    private bool isJumpPressed = false;
    private int contact = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        contact = 1;

    }
    void Update()
    {

        if (contact == 1)
            {
            isJumpPressed = ((Input.GetKey(KeyCode.W)));
        }
        
    }

    void FixedUpdate()
    {
        if (isJumpPressed)
        {
            // the cube is going to move upwards in 10 units per second
            
            
            rb.velocity = new Vector3(0, 15, 0);
            isMoving = true;
            Debug.Log("jump");
            contact = 0;
            isJumpPressed = false;
        }

        if (isMoving)
        {
            // when the cube has moved for 10 seconds, report its position
            time = time + Time.fixedDeltaTime;
            if (time > 10.0f)
            {
                Debug.Log(gameObject.transform.position.y + " : " + time);
                time = 0.0f;
            }
        }
    }
    }