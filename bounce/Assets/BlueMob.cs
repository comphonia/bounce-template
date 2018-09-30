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
            GetComponent<SpriteRenderer>().color = Color.clear;
            PlayerController.instance.bounceForce *= bounceBonus;
            Debug.Log("bounce!");
            Invoke("BackToNormal", bounceBonusDuration);
        }
    }

    void BackToNormal()
    {
        PlayerController.instance.bounceForce /= bounceBonus;
    }
}
