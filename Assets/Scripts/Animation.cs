using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Movement.direction.x != 0) // direction is not equals 0
        {
            animator.SetBool("IsWalk", true); // start anim walk
        }
        else
            animator.SetBool("IsWalk", false); // stop anim walk
    }
}
