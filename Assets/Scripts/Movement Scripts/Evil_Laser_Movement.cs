using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evil_Laser_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Level_Manager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0, -10, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        this.transform.position = new Vector3(8, -1000, 0);
        if (collision.gameObject.tag == "Player")
        {
            levelManager.LoadLevel("Lose");
        }
        if (collision.gameObject.tag == "Enemy")
        {
            levelManager.LoadLevel("Win");
        }
    }

}
