using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMob : MonoBehaviour {

    [Tooltip("1 = normal")]
    [SerializeField] float bounceBonus = 1.5f;
    [SerializeField] float bounceBonusDuration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !PlayerController.instance.bounceBonusActive)
        {
            GetComponent<SpriteRenderer>().color = Color.clear;     //The mob disappears
            PlayerController.instance.bounceForce *= bounceBonus;   //The bounceForce of the player is improved
            Debug.Log("Bounce!");
            Invoke("BackToNormal", bounceBonusDuration);    //after bounceBonusDuration the bonus is removed
        }
    }

    void BackToNormal()
    {
        PlayerController.instance.bounceForce /= bounceBonus;
    }
}
