using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public NextScene nextScene;

    public void LoadMenu()
    {
        nextScene.nextSceneName = "Menu";
        SceneManager.LoadScene("LoadingScene", LoadSceneMode.Single);
    }
}
