using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerModos : MonoBehaviour
{
    public LevelLoaderController levelLoader;
    public RectTransform panelSelectModos;
    public RectTransform panelBackToApresentation;
    private void Start()
    {
        panelSelectModos.LeanScale(new Vector3(1f, 1f, 1f), 1.2f);
        panelBackToApresentation.LeanScale(new Vector3(1f, 1f, 1f), 1.2f);
    }
    public void GoModoOne(string sceneOne)
    {
        levelLoader.Transition(sceneOne);
        panelSelectModos.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
        panelBackToApresentation.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
    }

    public void GoModoTwo(string sceneTwo)
    {
        levelLoader.Transition(sceneTwo);
        panelSelectModos.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
        panelBackToApresentation.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
    }

    public void BackToApresentationScene(string sceneName)
    {
        levelLoader.Transition(sceneName);
        panelSelectModos.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
        panelBackToApresentation.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
    }
}
