using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

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

    bool leftPressed, rightPressed;

    private void Start()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
        rbPlayer = GetComponent<Rigidbody2D>();
        sRenderer = GetComponent<SpriteRenderer>();

        if(DontDestroy.instance != null)
        GetComponent<SpriteRenderer>().sprite = DontDestroy.instance.playerSprite.sprite;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || leftPressed)
        {
            movingLeft = true;
            StartCoroutine(MovingLeft());
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || rightPressed) 
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
        if ((direction.x < Mathf.Sqrt(2) / 2 || direction.x > -Mathf.Sqrt(2) / 2) && direction.y >= 0)
            Bounce(Vector2.up);
    }

    public void Bounce(Vector2 direction)
    {
        rbPlayer.velocity = new Vector2(0, bounceForce * Time.fixedDeltaTime); 
    }

    private void OnDestroy()
    {
        if (GameMaster.instance != null) GameMaster.instance.GameOver();
       
    }

  // Used by the eventtrigger component on buttons to determine key press
    public void LeftButtonPress(bool isPressed)
    {
        if (isPressed)
        {
            movingLeft = true;
            leftPressed = true;
        }
        else
        {
            movingLeft = false;
            leftPressed = false;
        }
    }

    public void RightButtonPress(bool isPressed)
    {
        if (isPressed)
        {
            movingRight = true;
            rightPressed = true;
        }
        else {
            movingRight = false;    
            rightPressed = false;
        }
    }



}
