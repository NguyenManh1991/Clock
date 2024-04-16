using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
   [SerializeField] Transform hoursPivot;
   [SerializeField] Transform minutesPivot;
   [SerializeField] Transform secondsPivot;
    const float hoursToDegrees = 30f, minutesToDegrees = 6f, secondsToDegrees = 6f;

    private void Awake()
    {
        
    }

    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation =Quaternion.Euler(0,hoursToDegrees*(float)time.TotalHours,0);
        minutesPivot.localRotation=Quaternion.Euler(0,minutesToDegrees*(float)time.TotalMinutes,0);
        secondsPivot.localRotation = Quaternion.Euler(0,secondsToDegrees*(float)time.TotalSeconds,0);    

    }

}
