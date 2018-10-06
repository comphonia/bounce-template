using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

    GameObject deathPanel;
    GameObject menuPanel;
    Button backButton; 

    private void Awake()
    {
        deathPanel = GameMaster.instance.deathPanel;
        menuPanel = GameMaster.instance.menuCanvas;
        backButton = GetComponent<Button>();
        backButton.onClick.AddListener(delegate { Back(); });
    }

    void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
