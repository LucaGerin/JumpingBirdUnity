
using UnityEngine;
using UnityEngine.UI; //To use Text type to reference the Text element of the UI in unity
using UnityEngine.SceneManagement; //To manage scene and restart it

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;


    [ContextMenu("Increase Score")] //To make unity see the function and be able to call it
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    //Deleted Start() and Update() methods as they were not used
}
