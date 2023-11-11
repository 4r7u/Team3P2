using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalMove = 0;
    float verticalMove = 0;
    public float runSpeedVertical = 3;
    public float runSpeedHorizontal = 3;
    public float runSpeed = 0;
    public float jumpForce = 2;
    public Animator animator;

    Rigidbody2D rigidbody2;
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (joystick.Vertical >= 0.5f && IsGrounded.isGrounded)
        {
            Jump();
            animator.SetBool("IsJumping", true);
        }
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;
    }
    public void OnLanding ()
    {
        animator.SetBool("IsJumpig", false);
    }
    public void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}
