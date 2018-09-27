using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float bounceForce;
    [SerializeField] float moveForce;
    [SerializeField] GameObject destroyedPlayerPref; 

    Rigidbody2D rbPlayer;

    public bool invincible = false;

    static public PlayerController instance; 

    private void Start()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || RightButton.isPressed) MoveRight();
        else if (Input.GetKey(KeyCode.LeftArrow) || LeftButton.isPressed) MoveLeft();
    }

    public void MoveLeft()
    {
        print("left click");
        rbPlayer.AddForce(Vector2.left * moveForce);
        //transform.Translate(Vector3.left * force/100 * Time.deltaTime); 
    }

    public void MoveRight()
    {
        print("right click");
        rbPlayer.AddForce(Vector2.right * moveForce);
        //rbPlayer.velocity = (Vector2.right * moveForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(rbPlayer.velocity.y); 
        if ( collision.gameObject.tag == "Ground")
        {
            Vector2 direction = collision.GetContact(0).normal;
            Bounce(direction); 
        }
    }

    public void Bounce(Vector2 direction)
    {
        //if (direction == Vector2.up)
        if ((direction.x < Mathf.Sqrt(2) / 2 || direction.x > -Mathf.Sqrt(2) / 2) && direction.y >= 0)
            rbPlayer.AddForce(direction * bounceForce);
    }

    private void OnDestroy()
    {
        //Instantiate(destroyedPlayerPref, transform.position, Quaternion.identity); 
    }


}
