using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObject : MonoBehaviour {

    float offsetY = 7;
    protected bool active = false;
	
	// Update is called once per frame
	protected virtual void Update () {

        if (transform.position.y - MainCamera.instance.transform.position.y <= offsetY)
        {
            active = true; 
        }

		if (MainCamera.instance.transform.position.y - transform.position.y >= offsetY)
        {
            Destroy(gameObject); 
        }
	}
}
