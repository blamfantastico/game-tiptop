using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Teak;

public class MainController : MonoBehaviour
{
    // PlayerPrefs constants
    public const string Prefs_BestScore_Key = "best_score";
    public const int Prefs_BestScore_DefaultValue = 0;

    public const string Prefs_ColorIndex_Key = "color_index";
    public const int Prefs_ColorIndex_DefaultValue = 1;

    public const string Prefs_Sounds_Key = "sounds";
    public const int Prefs_Sounds_DefaultValue = 1;

    void HandleLogEvent(Dictionary<string, object> logData) {
        Debug.Log(new TeakLogEvent(logData));
    }

    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Application.targetFrameRate = 60;

        Debug.Log("Teak NOW!!!!");

        Teak.Instance.OnLogEvent += HandleLogEvent;

        UserConfiguration userConfiguration = new UserConfiguration {
            Email = "user@test.com"
        };
        Teak.Instance.IdentifyUser("user_123456", userConfiguration); // Hardcoding the user ID: Not great.
    }
}
