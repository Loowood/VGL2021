using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelMenu;

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
        SceneManager.LoadScene("CastleScene", LoadSceneMode.Single);
    }

    public void LoadWaterFall()
    {
        SceneManager.LoadScene("WaterFallScene", LoadSceneMode.Single);
    }
}
