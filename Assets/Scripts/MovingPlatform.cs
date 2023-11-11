using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform posA, posB;
    public float speed;
    Vector3 targetPos;

    void Start()
    {
        targetPos = posB.position;
    }

   void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < 0.5f) targetPos = posB.position;

        if (Vector2.Distance(transform.position, posB.position) < 0.5f) targetPos = posA.position;
       
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    } 

}
