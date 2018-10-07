using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

    static public MainCamera instance; 

    [SerializeField] Transform target;
    [SerializeField] float offsetY;
    [SerializeField] float deathOffset;

    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
    }

    private void Update()
    {
        if (target != null) {
            FollowTarget();
            if (transform.position.y - target.position.y >= deathOffset)
            {
                Destroy(target.gameObject);
            }
        }

        
        
    }

    void FollowTarget()
    {
        if (target.position.y > (transform.position.y + offsetY))
        {
            float diff = target.position.y - (transform.position.y + offsetY);
            transform.position += Vector3.up * diff;
        }
    }
}
