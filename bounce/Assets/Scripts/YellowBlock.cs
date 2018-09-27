using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBlock : MonoBehaviour {

    bool dropped = false; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Vector2 direction = collision.GetContact(0).normal;
            Vector2 direction = Vector2.up; 
            //direction = -direction; 
            Debug.Log(direction); 
            PlayerController.instance.Bounce(direction); 
            if (!dropped) GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX; 
        }
    }
}
