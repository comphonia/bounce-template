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
            //GameObject destroyedBar = Instantiate(destroyedBarPref, transform.position, Quaternion.identity, transform.parent);
            //Destroy(destroyedBar, destroyedBarLifeTime); 
            Destroy(gameObject); 
        }
    }
}
