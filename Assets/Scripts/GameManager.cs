using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TMP_Text timer;
    public int timerNumber = 12;

    private void Start()
    {
        timerNumber = 12;
        StartCoroutine(Timer());
    }

    private void ChangeTimer()
    {
        timer.text = timerNumber + " AM";

        if (timerNumber == 6)
        {
            StartCoroutine(WinTimer());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(30f);
        
        if(timerNumber == 12)
        {
            timerNumber = 1;
            ChangeTimer();
        }
        else
        {
            timerNumber++;
            ChangeTimer();
        }

        StartCoroutine(Timer());
    }

    IEnumerator WinTimer()
    {
        yield return new WaitForSeconds(5f);
        sceneLoader.Win();
    }
}
