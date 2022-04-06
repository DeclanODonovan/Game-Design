using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;
    Vector3 paddleToBallVector;
    bool hasStarted = false;
    // Start is called before the first frame update
    void OnCollisonEnter2D(Collision2D collision)
    {
        if (hasStarted)
            this.GetComponent<AudioSource>().Play();
    }
    void Start()
    {
        paddleToBallVector = this.transform.position - paddle.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }


    }
}
