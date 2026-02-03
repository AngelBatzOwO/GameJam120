using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerBehaviour : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timerText;

    [SerializeField]
    float timer;

    [SerializeField]
    GameObject player;

    void Update()
    {
        timer += Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        StopTimer();
       
    }

    void StopTimer()
    {
        if (player.GetComponent<PlayerStatBehaviour>().health <= 0)
        {
            this.enabled = false;
        }
    }
}
