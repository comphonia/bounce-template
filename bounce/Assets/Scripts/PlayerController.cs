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
        //rbPlayer.AddForce(Vector2.left * moveForce);
        //transform.Translate(Vector3.left * moveForce * Time.deltaTime); 
        rbPlayer.velocity = new Vector2( - moveForce * Time.deltaTime, rbPlayer.velocity.y);
    }

    public void MoveRight()
    {
        //rbPlayer.AddForce(Vector2.right * moveForce);
        //transform.Translate(Vector3.right * moveForce * Time.deltaTime);
        rbPlayer.velocity = new Vector2(moveForce * Time.deltaTime, rbPlayer.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "Ground")
        {
            Vector2 direction = collision.GetContact(0).normal;
            //Vector2 direction = Vector2.up; 
            CheckNBounce(direction); 
        }
    }

    void CheckNBounce(Vector2 direction)
    {
        //if (direction == Vector2.up)
        Debug.Log(direction); 
        if ((direction.x < Mathf.Sqrt(2) / 2 || direction.x > -Mathf.Sqrt(2) / 2) && direction.y >= 0)
            Bounce(Vector2.up);
    }

    public void Bounce(Vector2 direction)
    {
        //rbPlayer.AddForce(direction * bounceForce);
        rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, bounceForce * Time.fixedDeltaTime); 
    }

    private void OnDestroy()
    {
        //Instantiate(destroyedPlayerPref, transform.position, Quaternion.identity); 
    }


}
