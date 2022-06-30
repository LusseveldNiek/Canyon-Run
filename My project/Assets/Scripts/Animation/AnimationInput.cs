using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationInput : MonoBehaviour
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
        bool running = Input.GetAxisRaw("Vertical") != 0;

        animator.SetInteger("Move State", running? 2 : 0 );
    }
}
