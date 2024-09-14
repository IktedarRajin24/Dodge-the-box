using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public void GameOver()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", 2f);
        }
    }

    public void GameWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
