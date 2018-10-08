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
            //GameObject destroyedBar = Instantiate(destroyedBarPref, transform.position, Quaternion.identity, transform.parent);
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None; 
            }
            Destroy(gameObject, destroyedBarLifeTime);
        }
    }
}
