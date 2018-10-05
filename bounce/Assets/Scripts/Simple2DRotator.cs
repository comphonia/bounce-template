﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple2DRotator : MonoBehaviour {

    [SerializeField] float speed;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,0,1*speed*Time.deltaTime);
	}
}
