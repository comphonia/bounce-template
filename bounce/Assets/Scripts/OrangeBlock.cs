using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeBlock : MonoBehaviour {

    bool dropped = false; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && dropped)
        {
            dropped = true; 
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            //when it's touched by the player the block is able to move without any costraints
            if (!dropped) rb.constraints = RigidbodyConstraints2D.None;
            rb.velocity = Vector2.zero;     //to make the first touch from the player do not make the block move
        }
    }
}
