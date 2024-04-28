using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {
        SceneManager.LoadScene(2);
    }

    public void HomeScreen()
    {
      SceneManager.LoadScene(0);
    }

    public void FireScene()
    {
      SceneManager.LoadScene(4);
    }

    public void WaterScene()
    {
      SceneManager.LoadScene(3);
    }

    public void EarthScene()
    {
      SceneManager.LoadScene(5);
    }
}
