using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
 
    public void LoadLevel(string win)
    {
        SceneManager.LoadScene(win);
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

