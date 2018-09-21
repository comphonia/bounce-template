using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] float force;
    Rigidbody2D rbPlayer;

    private void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) MoveRight();
        else if (Input.GetKey(KeyCode.LeftArrow)) MoveLeft();
    }

    public void MoveLeft()
    {
        print("left click");
        //rbPlayer.AddForce(Vector2.left * force);
        transform.Translate(Vector3.left * force/100 * Time.deltaTime); 
    }

    public void MoveRight()
    {
        print("right click");
        //rbPlayer.AddForce(Vector2.right * force);
        rbPlayer.velocity = (Vector2.right * force);
    }

    
}
