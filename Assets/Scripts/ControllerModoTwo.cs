using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerModoTwo : MonoBehaviour
{
    private float timerControllerRandomNumbers = 1.5f;
    private bool checkClickRandomButton = false;
    private int minValue = 1;
    private int maxValue = 11;
    private int randomNumber;
    public Text txtRandomNumber;
    public GameObject spawnItem;
    public GameObject item;

    void Update()
    {
        if(checkClickRandomButton)
        {
            timerControllerRandomNumbers -= Time.deltaTime;

            if(timerControllerRandomNumbers < 0)
            {
                randomNumber = Random.Range(minValue, maxValue);
                txtRandomNumber.text = randomNumber.ToString();
                checkClickRandomButton = false;

                if(!checkClickRandomButton)
                {
                    if(timerControllerRandomNumbers < 0)
                    {
                        timerControllerRandomNumbers = 1.5f;
                    }
                }
            }
        }

        if(!GameObject.FindGameObjectWithTag("DragItem"))
        {
            Instantiate(item, spawnItem.transform.position, spawnItem.transform.rotation);
        }
    }

    public void Add_Random_Number()
    {
        checkClickRandomButton = true;
    }
}
