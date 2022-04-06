using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
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
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("Anim", 1);
            animator.SetInteger("Anim2", 1);
        }
        else
        {
            animator.SetInteger("Anim", 0);
            animator.SetInteger("Anim2", 0);
        }
    }
}
