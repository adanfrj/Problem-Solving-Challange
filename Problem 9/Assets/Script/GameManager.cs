using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int lives;
    public int brickz;
    public Text livesText;
    public Text scoreTexts;
    public bool gameOver;
    public bool nextLevel;
    public GameObject gameOverPanel;
    public GameObject winPanel;
    public int numberOfBricks;

    // Start is called before the first frame update
    void Start()
    {
        scoreTexts.text = "Score : " + score;
        livesText.text = "Lives : " + lives;
        numberOfBricks = GameObject.FindGameObjectsWithTag("brick").Length;
    }

    public void UpdateScore(int point)
    {
        score += point;
        scoreTexts.text = "Score : " + score;
    }

    public void UpdateNumberOfBrick()
    {
        numberOfBricks--;
        if(numberOfBricks <= 1)
        {
            NextLevel();
        }
        
    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;
        livesText.text = "Lives : " + lives;

        if (lives <= 0)
        {
            lives = 0;
            GameOver();
        }
    }

    public void UpdateBrick(int jumlahbrick)
    {
        brickz -= jumlahbrick;
        if (brickz <= 0)
        {
            brickz = 10;
            NextLevel();
        }
    }

    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);

    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    void NextLevel()
    {
        nextLevel = true;
        winPanel.SetActive(true);
        
    }

    public void NextLevelGame()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
