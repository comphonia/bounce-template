using UnityEngine.SceneManagement; 
using UnityEngine;

public class PausePanel : MonoBehaviour {

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }
    private void OnDisable()
    {
        Time.timeScale = 1f; 
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene"); 
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Continue()
    {
        PausePanelController.instance.CloseMenu(); 
    }
}
