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
            if (collision.gameObject.GetComponent<PlayerController>().invincible)
            {
                Destroy(gameObject); 
            }
            else
            {
                //GameObject destroyedBlock = Instantiate(destroyedBlockPref, transform.position, Quaternion.identity, transform.parent);
                //Destroy(destroyedBlock, destroyedBlockLifeTime); 
                Destroy(collision.gameObject); 
            }
        }
    }
}
