using UnityEngine.UI; 
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    Button playButton;

    private void Awake()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(delegate { SceneManager.LoadScene("GameScene"); });
    }
}
