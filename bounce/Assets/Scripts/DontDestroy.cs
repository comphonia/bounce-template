﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance = null; //The instance of this - that's going to be unique, because of the instance variable
    public SpriteRenderer playerSprite;        //will bring the playerSprite information, particurarly from the Menu scene to the GameScene scene

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }
}
