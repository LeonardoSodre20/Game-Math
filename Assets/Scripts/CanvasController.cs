using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public LevelLoaderController levelLoader;
   public void ButtonPlay(string sceneName)
    {
        levelLoader.Transition(sceneName);
    }
}
