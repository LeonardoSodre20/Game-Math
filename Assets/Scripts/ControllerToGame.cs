using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerToGame : MonoBehaviour
{
    private int randomNumber;
    private bool checkClickButton = false;
    private float timerControl = 1.5f;
    public int minValue;
    public int maxValue;
    private int qtdInputs = 0;
    public Text randomNumberTxt;
    public GameObject panelVictory;
    public RectTransform panelTransform;
    public HudControllerModoOne hudController;
    public RectTransform btnRandomNumber;
    public RectTransform backgroundRandomNumber;

    void Update()
    {
        if(checkClickButton)
        {
            timerControl -= Time.deltaTime;

            if(timerControl < 0)
            {
                randomNumber = Random.Range(minValue, maxValue);
                randomNumberTxt.text = randomNumber.ToString("F0");
                checkClickButton = false;

                if(!checkClickButton)
                {
                    if(timerControl < 0)
                    {
                        timerControl = 1.5f;
                    }
                }
            }
        }

        if (Input.touchCount > 0)
        {
            Touch countTouch = Input.GetTouch(0);
            Vector2 t = Camera.main.ScreenToViewportPoint(countTouch.position);

            qtdInputs = Input.touchCount;

            if (qtdInputs == randomNumber)
            {
                panelVictory.SetActive(true);
                LeanTween.scale(panelTransform.gameObject, new Vector3(1f, 1f, 1f), 1.2f);
                hudController.btnPause.LeanMoveX(-199f, 0.5f);
                btnRandomNumber.LeanScale(new Vector3(0f, 0f, 0f), 0.5f);
                backgroundRandomNumber.LeanScale(new Vector3(0f, 0f, 0f), 0.5f);
            }
        }
    }

    public void Random_Number()
    {
        checkClickButton = true;
    }
    
}
