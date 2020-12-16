using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.orientation = ScreenOrientation.Portrait;
        Time.timeScale = 1.0f;
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }
}
