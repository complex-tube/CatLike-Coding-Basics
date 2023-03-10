using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    
    const float hoursToDegrees = -30, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField] private Transform hoursPivot, minutesPivot, secondsPivot;
    // Start is called before the first frame update
    void Update ()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }
}
