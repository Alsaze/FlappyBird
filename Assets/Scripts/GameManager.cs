using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private int _score;

    public void Lose()
    {
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SceneGame");
        _score = 0;
        Time.timeScale = 1;
    }
    public void Score()
    {
        _score++;
    }

    private void Update()
    {
        scoreText.text = _score.ToString();
    }
}
