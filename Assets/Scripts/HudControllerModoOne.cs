using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudControllerModoOne : MonoBehaviour
{
    [Header("Animações da HUD:")]
    public RectTransform panel;
    public RectTransform btnPause;
    public RectTransform btnRandomNumber;
    public RectTransform backgroundRandomNumber;
    public RectTransform[] btnConfig;

    [Header("Configurações Gerais:")]
    public LevelLoaderController levelLoader;
    public ControllerToGame controllerGame;

    private void Start()
    {
        btnRandomNumber.LeanScale(new Vector3(1.2f, 1.2f, 1.2f), 1.2f);
        btnPause.LeanScale(new Vector3(1.2f, 1.2f, 1.2f), 1.2f);
        backgroundRandomNumber.LeanScale(new Vector3(1.2f, 1.2f, 1.2f), 1.2f);
    }

    public void Pause_Game()
    {
        panel.LeanMoveY(0f, 1f).setEaseInBack();
        btnPause.LeanMoveX(-199f, 0.5f);
        for(int i = 0; i < btnConfig.Length; i++)
        {
            btnConfig[i].LeanScale(new Vector3(1.2f, 1.2f, 1.2f), 2f).setEaseInBack();
        }
    }

    public void Close_Panel_Pause()
    {
        panel.LeanMoveY(1479f, 1f).setEaseInOutBack();
        btnPause.LeanMoveX(116f, 1.2f);
        for (int i = 0; i < btnConfig.Length; i++)
        {
            btnConfig[i].LeanScale(new Vector3(0f, 0f, 0f), 2f).setEaseInBack();
        }
    }

    public void Restart_Game(string scene)
    {
        levelLoader.Transition(scene);
        controllerGame.panelVictory.SetActive(false);
        btnRandomNumber.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
        btnPause.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
        backgroundRandomNumber.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
    }

    public void BackToMenu(string scene)
    {
        levelLoader.Transition(scene);
        controllerGame.panelVictory.SetActive(false);
        btnRandomNumber.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
        btnPause.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
        backgroundRandomNumber.LeanScale(new Vector3(0f, 0f, 0f), 1.2f);
    }
}
