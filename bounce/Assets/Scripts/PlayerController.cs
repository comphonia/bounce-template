using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float bounceForce;
    [SerializeField] float moveForce;
    [SerializeField] GameObject destroyedPlayerPref;
    [HideInInspector] public bool movingLeft;
    [HideInInspector] public bool movingRight; 

    Rigidbody2D rbPlayer;

    [HideInInspector] public bool invincible = false;
    [HideInInspector] public bool bounceBonusActive = false; 

    static public PlayerController instance;

    SpriteRenderer sRenderer; 

    private void Start()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
        rbPlayer = GetComponent<Rigidbody2D>();
        sRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movingLeft = true;
            StartCoroutine(MovingLeft());
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            movingRight = true;
            StartCoroutine(MovingRight()); 
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow)) movingLeft = false;
        else if (Input.GetKeyUp(KeyCode.RightArrow)) movingRight = false;
    }

    public IEnumerator MovingRight()
    {
        while (movingRight)
        {
            rbPlayer.velocity = new Vector2(moveForce * Time.deltaTime, rbPlayer.velocity.y);
            yield return null; 
        }
        rbPlayer.velocity = new Vector2(0, rbPlayer.velocity.y);
        yield break; 
    }

    public IEnumerator MovingLeft()
    {
        while (movingLeft)
        {
            rbPlayer.velocity = new Vector2(-moveForce * Time.deltaTime, rbPlayer.velocity.y);
            yield return null; 
        }
        rbPlayer.velocity = new Vector2(0, rbPlayer.velocity.y);
        yield break; 
    }

    public void MoveLeft()
    {
        //rbPlayer.AddForce(Vector2.left * moveForce);
        //transform.Translate(Vector3.left * moveForce * Time.deltaTime); 
        rbPlayer.velocity = new Vector2(moveForce * Time.deltaTime, rbPlayer.velocity.y);
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
        if ((direction.x < Mathf.Sqrt(2) / 2 || direction.x > -Mathf.Sqrt(2) / 2) && direction.y >= 0)
            Bounce(Vector2.up);
    }

    public void Bounce(Vector2 direction)
    {
        //rbPlayer.AddForce(direction * bounceForce);
        rbPlayer.velocity = new Vector2(0, bounceForce * Time.fixedDeltaTime); 
    }

    private void OnDestroy()
    {
        GameMaster.instance.GameOver(); 
        //Instantiate(destroyedPlayerPref, transform.position, Quaternion.identity); 
    }


}
