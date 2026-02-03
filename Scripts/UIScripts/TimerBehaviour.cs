using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TimerBehaviour : MonoBehaviour
{
    [SerializeField]
    TMP_Text timeText;

    [SerializeField]
    float timers;

    TimeSpan timespan;

    void Update()
    {
        timer += Time.deltaTime;

        timeText.text = timer.ToString();

        timespan = TimeSpan.FromSeconds(timer);

        timeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
    }
}
