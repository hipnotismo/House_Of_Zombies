using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadScene(string sceneNamde)
    {
        SceneManager.LoadScene(sceneNamde);
    }
    public void SetTimeToOne()
    {
        Time.timeScale = 1;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
