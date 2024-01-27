using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update

    public void LoadControlScene()
    {
        SceneManager.LoadScene("ControlMenu");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadStartMenuScene()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
