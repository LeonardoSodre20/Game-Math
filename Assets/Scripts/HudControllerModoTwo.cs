using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudControllerModoTwo : MonoBehaviour
{

    public RectTransform panelVictory;
    public LevelLoaderController levelLoader;

    public void CheckVictorySystem()
    {
        panelVictory.LeanScale(new Vector3(1f, 1f, 1f), 1.2f);
    }

    public void Restart(string sceneName)
    {
        levelLoader.Transition(sceneName);
    }

    public void BacktoMenu(string sceneName)
    {
        levelLoader.Transition(sceneName);
    }
}
