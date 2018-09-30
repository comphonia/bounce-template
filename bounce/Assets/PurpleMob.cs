using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleMob : MonoBehaviour {

    [Tooltip("0 = paused, 1 = normal")]
    [SerializeField] float slowMotionValue = 0.5f;
    [SerializeField] float slowMotionDuration = 5f; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = Color.clear;
            Time.timeScale = slowMotionValue;
            Debug.Log("slowMotion"); 
            Invoke("BackToNormal", slowMotionDuration); 
        }
    }

    void BackToNormal()
    {
        Time.timeScale = 1;
    }
}
