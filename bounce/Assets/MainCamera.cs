using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

    [SerializeField] Transform target;
    [SerializeField] float offsetY; 

    private void Update()
    {
        if (target != null) {
            FollowTarget(); 
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
