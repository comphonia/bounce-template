using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

    Button backButton; 

    private void Awake()
    {
        backButton = GetComponent<Button>();
        backButton.onClick.AddListener(delegate { Back(); });
    }

    void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
