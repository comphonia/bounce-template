using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBar : MonoBehaviour {

    [SerializeField] GameObject destroyedBarPref;
    [SerializeField] float destroyedBarLifeTime; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager.IncreaseScore();
            GetComponent<BoxCollider2D>().enabled = false; 
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None; 
            }
            GetComponent<Collider2D>().enabled = false; 
            Destroy(gameObject, destroyedBarLifeTime);
        }
    }
}
