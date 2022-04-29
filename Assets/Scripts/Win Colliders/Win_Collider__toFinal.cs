using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Collider__toFinal : MonoBehaviour
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
        LoadLevel("Final Battle");
    }
    public void LoadLevel(string level)
    {
        levelManager.LoadLevel(level);
    }
}
