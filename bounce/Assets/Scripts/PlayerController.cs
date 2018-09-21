using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

   [SerializeField] private GameObject player;
    [SerializeField]float force;
    Rigidbody2D rbPlayer;

    private void Start()
    {
        player = gameObject;
        rbPlayer = player.GetComponent<Rigidbody2D>();
    }

    public void LeftForce()
    {
        print("left click");
        rbPlayer.AddForce(Vector2.left * force);
    }

    public void RightForce()
    {
        print("right click");
        rbPlayer.AddForce(Vector2.right * force);
    }
}
