using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBlock : MonoBehaviour {

    bool dropped = false; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            //if (!dropped) rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
            if (!dropped) rb.constraints = RigidbodyConstraints2D.None;
            rb.velocity = Vector2.zero; 
        }
    }
}
