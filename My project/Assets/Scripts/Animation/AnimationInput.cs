using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationInput : MonoBehaviour
{
    public Animator animator;
    public bool standing;
    public GameObject playerModel;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        playerModel = GameObject.Find("Adventurer");
        animator = playerModel.GetComponent<Animator>();
        Jumping jumping = player.GetComponent<Jumping>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Jumping jumping = player.GetComponent<Jumping>();
        standing = jumping.isGrounded;
        bool running = Input.GetAxisRaw("Vertical") != 0;          
        animator.SetInteger("Move State", running? 2 : 0);          
        if(standing == true)
        {
            animator.SetBool("IsGrounded", true);
        }

        if(standing == false)
        {
            animator.SetBool("IsGrounded", false);
        }
        
    }
}
