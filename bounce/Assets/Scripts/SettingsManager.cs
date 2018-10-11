using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class SettingsManager : MonoBehaviour {

    [SerializeField] Button[] characters;
    [SerializeField] Image logoCharacter;
    [SerializeField] SpriteRenderer playerCharacter;
    [SerializeField] GameObject charPanel;
    [SerializeField] GameObject infoPanel;
    [SerializeField] TextMeshProUGUI audioTMP;

    [SerializeField] AudioMixer audioMixer;

    private void Start()
    {

        characters[0].onClick.AddListener(delegate { SetCharacterImage(0); });
        characters[1].onClick.AddListener(delegate { SetCharacterImage(1); });
        characters[2].onClick.AddListener(delegate { SetCharacterImage(2); });
        characters[3].onClick.AddListener(delegate { SetCharacterImage(3); });
        playerCharacter.sprite = characters[0].image.sprite;

    }

    //sets menu image to selected sprite
    public void SetCharacterImage(int index)
    {
        logoCharacter.sprite = characters[index].image.sprite;
        playerCharacter.sprite = characters[index].image.sprite;
    }

    //panel toggles

    bool isVisible;
    public void ToggleCharacter()
    {
        isVisible = !isVisible;
        charPanel.SetActive(isVisible);
    }

    bool isMuted;
    public void ToggleSound()
    {
        isMuted = !isMuted;
        if (isMuted)
        {
            audioMixer.SetFloat("volume", 0);
            audioTMP.text = "";
        }
        else
        {
            audioMixer.SetFloat("volume", 1);
            audioTMP.text = "";
        }

    }

    bool isInfo;
    public void ToggleInfo()
    {
        isInfo = !isInfo;
        infoPanel.SetActive(isInfo);
    }



    

}
