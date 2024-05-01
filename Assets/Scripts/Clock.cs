using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f;
    const float minutesToDegrees = -6f;
    const float secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Awake()
    {
        DateTime now = DateTime.Now;
        int hours = now.Hour;
        int minutes = now.Minute;
        int seconds = now.Second;

        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (hours + minutes / 60f));
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * minutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * seconds);
    }

    void Update()
    {
        TimeSpan now = DateTime.Now.TimeOfDay;

        float hours = (float)now.TotalHours;
        float minutes = (float)now.TotalMinutes;
        float seconds = (float)now.TotalSeconds;

        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (hours + minutes / 60f));
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * minutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * seconds);
    }
}