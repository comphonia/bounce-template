using UnityEngine.UI; 
using UnityEngine;
using UnityEngine.SceneManagement; 

public class RestartButton : MonoBehaviour {

    Button restartButton;

    private void Awake()
    {
        restartButton = GetComponent<Button>();
        restartButton.onClick.AddListener(delegate { SceneManager.LoadScene("GameScene"); }); 
    }
}
