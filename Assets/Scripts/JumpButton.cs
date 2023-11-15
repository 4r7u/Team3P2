using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    public MovementManager movementManager;

    public void Jump()
   {
       if (movementManager.IsJumping == false)
        {
            movementManager.IsJumping = true;

            movementManager.rb.velocity += Vector2.up * 8f;
        }
    }
}    

