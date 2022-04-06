using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    public void BrickDestroyed()
    {
        if (Brick.brickCount <= 0)
            LoadLevel("Win");
    }
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadLose(string lose)
    {
        SceneManager.LoadScene(lose);
    }
}
