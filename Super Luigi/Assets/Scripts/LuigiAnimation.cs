using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuigiAnimation : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("LuigiState", 1);
            animator.SetInteger("LuigiState2", 1);
        }
        else
        {
            animator.SetInteger("LuigiState", 0);
            animator.SetInteger("LuigiState2", 0);
        }
    }
}
