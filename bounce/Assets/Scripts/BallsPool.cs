using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsPool : SceneObject {

    [SerializeField] GameObject[] ballsToInstantiate;
    [SerializeField] float timeToInstantiate;
    float timer = 0;
    int i = 0; 

    bool visible; 

    protected override void Update()
    {
        base.Update(); 

        if (active)
        {
            if (timer >= timeToInstantiate)
            {
                timer = 0;

                i++;
                i = i % ballsToInstantiate.Length;
                Instantiate(ballsToInstantiate[i], transform.position + new Vector3(Random.Range(-0.02f, 0.02f), 0, 0), Quaternion.identity, transform);
            }

            timer += Time.deltaTime;
        }
    }
}
