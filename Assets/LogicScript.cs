using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public GameObject gameOverScreen;
    
    

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        if (!gameOverScreen.activeInHierarchy)
        {
            PlayerScore++;
            ScoreText.text = PlayerScore.ToString();
        } 
    }

    public void StartGame()
    {
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
        SceneManager.LoadSceneAsync("gameScene", LoadSceneMode.Single);
    }

    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        
    }
}
