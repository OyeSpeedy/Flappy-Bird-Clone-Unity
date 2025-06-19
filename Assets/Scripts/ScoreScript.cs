using UnityEngine;
using System.Collections;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private int _score;
    private int _highScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentScoreText.text = _score.ToString();

        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }
        
    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = _score.ToString();
        }
        
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
