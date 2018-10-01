using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

    static public GameMaster instance;
    [SerializeField] GameObject deathPanel;
    [SerializeField] GameObject gameCanvas;
    [SerializeField] GameObject menuCanvas;



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
