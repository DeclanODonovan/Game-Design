using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Platform : MonoBehaviour
{
    public int movementspeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.A))
        {
            transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.D))
        {
            transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
        }
    }
}
