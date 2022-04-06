using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pipe_Collider : MonoBehaviour
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
        LoadLevel("Win");
    }
    public void LoadLevel(string level)
    {
        levelManager.LoadLevel(level);
    }
}
