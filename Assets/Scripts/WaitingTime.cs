using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitingTime : MonoBehaviour
{
    public Image cooling;
    public static bool ready = true;
    float waitingTime = 2;
    float currentTime = 0;
    // Use this for initialization
    void Start()
    {
        cooling.fillAmount = 1f;
        currentTime = 0;
        ready = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ready)
        {
            currentTime += Time.deltaTime;

            cooling.fillAmount = currentTime / waitingTime;
            if (currentTime >= waitingTime)
            {
                currentTime = 0;
                ready = true;
            } 
           

        }
    }
}
