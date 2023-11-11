using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalMove = 0;
    public float runSpeedHorizontal = 3;
    public float runSpeed = 0;
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
      
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;
    }
   
}
