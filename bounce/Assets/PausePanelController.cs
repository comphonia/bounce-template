using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanelController : MonoBehaviour {

    public static PausePanelController instance; 
    [SerializeField] GameObject pausePanel;

    [HideInInspector] public bool open = false;

    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
    }

    public void OpenMenu()
    {
        pausePanel.SetActive(true);
    }

    public void CloseMenu()
    {
        pausePanel.SetActive(false); 
    }
}
