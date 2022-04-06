using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Win_Collider : MonoBehaviour
{
    public Level_Manager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        LoadLevel("Platforming 1");
    }
    public void LoadLevel(string level)
    {
        levelManager.LoadLevel(level);
    }
}
