using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject destroyedBlockPref;
    [SerializeField] float destroyedBlockLifeTime = 2f; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.GetComponent<PlayerController>().invincible) //if player is invicible, the enemy is destroyed...
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
