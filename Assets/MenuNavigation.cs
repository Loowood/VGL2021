using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelMenu;
    public NextScene nextScene;
    private void Awake()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
    }

    public void ShowLevelMenu()
    {
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Application stop");
    }

    public void LoadCastle()
    {
        nextScene.nextSceneName = "CastleScene";
        SceneManager.LoadScene("LoadingScene", LoadSceneMode.Single);
    }

    public void LoadWaterFall()
    {
        nextScene.nextSceneName = "WaterFallScene";
        SceneManager.LoadScene("LoadingScene", LoadSceneMode.Single);
    }
}
