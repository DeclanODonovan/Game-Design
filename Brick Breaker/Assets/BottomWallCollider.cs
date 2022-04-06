using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallCollider : MonoBehaviour
{

    public Level_Manager levelManager;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        levelManager.LoadLevel("Lose");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
