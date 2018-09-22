using TMPro; 
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    static int score;
    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            ScoreManager.instance.UpdateUI(); 
        }
    }

    [SerializeField] TextMeshProUGUI scoreText; 

    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false;

        Score = 0; 
    }

    public static void IncreaseScore(int amount = 1 )
    {
        Score += amount;  
    }

    private void UpdateUI()
    {
        scoreText.text = score.ToString(); 
    }
}
