using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{

    public Rigidbody2D rb;
    public bool IsJumping = false;
    public Animator animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
            Debug.Log("Hit");
            IsJumping = false;
            animator.SetBool("IsJumping", true);
    }
    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }

}
