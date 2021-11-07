using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour
{
    public NextScene nextScene;
    public Scrollbar loadingbar;
    public LoadingTipsHandler tipsHandler;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadingBar(10f));
        tipsHandler.displayNewTip();
    }

    public void goToNextScene()
    {
        Debug.Log("Next Scene !");
        SceneManager.LoadScene(nextScene.nextSceneName, LoadSceneMode.Single);
    }

    private IEnumerator LoadingBar(float loadTime)
    {
        float elapsedTime = 0;
        while (elapsedTime < loadTime)
        {
            loadingbar.value = Mathf.Lerp(0f, 1f, (elapsedTime / loadTime));
            elapsedTime += Time.deltaTime;

            // Yield here
            yield return null;
        }
        goToNextScene();
    }

    private float SuperLerp(float from, float to, float from2, float to2, float value)
    {
        if (value <= from2)
            return from;
        else if (value >= to2)
            return to;
        return (to - from) * ((value - from2) / (to2 - from2)) + from;
    }
}
