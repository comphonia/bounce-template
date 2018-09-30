using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    static public GameMaster instance;
    [SerializeField] GameObject deathPanel; 

    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
    }

    public void GameOver()
    {
        deathPanel.SetActive(true); 
    }
}
