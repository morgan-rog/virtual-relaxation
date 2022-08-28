using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;

    private void Start()
    {
        fadeScreen.gameObject.SetActive(false);
    }

    public void GoToScene(string scene)
    {
        StartCoroutine(GoToSceneRoutine(scene));
    }
    
    IEnumerator GoToSceneRoutine(string scene)
    {
        fadeScreen.gameObject.SetActive(true);
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        // Launch the new scene
        SceneManager.LoadScene(scene);
        fadeScreen.gameObject.SetActive(false);
    }
}
