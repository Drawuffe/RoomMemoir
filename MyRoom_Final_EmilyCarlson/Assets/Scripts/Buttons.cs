using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);

    }

    public void Settings()
    {
        SceneManager.LoadScene(2);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }
}
