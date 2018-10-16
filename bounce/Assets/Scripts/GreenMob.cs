using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMob : MonoBehaviour {

    [SerializeField] float invicDuration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = Color.clear; 
            PlayerController.instance.invincible = true;
            Invoke("BackToNormal", invicDuration);
        }
    }

    void BackToNormal()
    {
        PlayerController.instance.invincible = false;
        Destroy(gameObject); 
    }
}
