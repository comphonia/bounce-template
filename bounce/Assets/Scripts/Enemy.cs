using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject destroyedBlockPref;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.GetComponent<PlayerController>().invincible) //if the player is invicible, the enemy is destroyed...
            {
                Destroy(gameObject); 
            }
            else // ... otherwise, the player is destroyed  
            {
                Destroy(collision.gameObject); 
            }
        }
    }
}
