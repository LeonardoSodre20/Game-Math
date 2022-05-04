using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderController : MonoBehaviour
{
    public Animator transitionAnimator;
    public void Transition(string sceneName)
    {
        StartCoroutine(LoadScene(sceneName));
    }

    IEnumerator LoadScene(string sceneName)
    {
        transitionAnimator.SetTrigger("Start");

        yield return new WaitForSeconds(2.2f);

        SceneManager.LoadScene(sceneName);
    }
}
