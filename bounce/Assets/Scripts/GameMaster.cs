using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

    static public GameMaster instance;
    public GameObject deathPanel;
    public GameObject gameCanvas;
    public GameObject menuCanvas;



    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
    }


    public void GameOver()
    {
        deathPanel.SetActive(true); 
    }

    public void Play()
    {
        menuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
    }

 


}
