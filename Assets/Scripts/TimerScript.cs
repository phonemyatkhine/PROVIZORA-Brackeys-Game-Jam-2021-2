using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    public float timer;
    public Text timer_text;
    public float second;
    public int minute;
    public ScoreKeeper score_keeper;
    // Start is called before the first frame update
    void Start()
    {
        minute = 0;
        // timer_text.text = timer.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        second = Mathf.Round(timer * 100) / 100;
        if(second == 60) {
            second = 0;
            timer = 0;
            minute += 1;
        }
        timer_text.text = minute + ":" + second;
    }

    public int getMinute() {
        return minute;
    }
}
