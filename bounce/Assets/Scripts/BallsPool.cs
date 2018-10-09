using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsPool : SceneObject { //The class BallsPool inherits the class SceneObject (look up C# inheritance)

    [SerializeField] GameObject[] ballsToInstantiate;       //prefabs of the balls I want to instantiate
    [SerializeField] float timeToInstantiate;               //how much between one instantation and the another one
    float timer = 0;
    int i = 0; 

    bool visible; 

    protected override void Update()
    {
        base.Update(); 

        if (active)     //if the player is near the object (see SceneObject.cs)
        {
            if (timer >= timeToInstantiate)     //if it's time to instatiate a ball
            {
                timer = 0;

                i++;                                    //increments the index of the prefabs' list...
                i = i % ballsToInstantiate.Length;      //... and makes sure that's between 0 and the max possible index
                //
                Instantiate(ballsToInstantiate[i], transform.position + new Vector3(Random.Range(-0.02f, 0.02f), 0, 0), Quaternion.identity, transform);
            }

            timer += Time.deltaTime;
        }
    }
}
