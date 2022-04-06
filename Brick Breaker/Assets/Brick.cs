using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Level_Manager levelManager;
    public int maxHits;
    int timesHit;
    public static int brickCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        timesHit = 0;
        brickCount++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            brickCount--;
            levelManager.BrickDestroyed();
            Destroy(gameObject);
        }

            
    }
}
