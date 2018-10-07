using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBlock : MonoBehaviour {

    bool moving = false;
    [SerializeField] float moveSpeed = 0.2f; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !moving)
        {
            moving = true; 
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            int direction = Random.Range(0, 2) == 0 ? -1 : 1;
            rb.velocity = Vector3.right * direction * moveSpeed;
           // Debug.Log(moveSpeed);
          //  Debug.Log(rb.velocity); 
        }
    }
}
