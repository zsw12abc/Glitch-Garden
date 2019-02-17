using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    private const string MASTER_VOLUMNE_KEY = "master volume";
    private const string DIFFICULTY_KEY = "difficulty";
    private const float MIN_VOLUMNE =0f;
    private const float MAX_VOLUMNE = 1f;

    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUMNE && volume <= MAX_VOLUMNE)
        {
            Debug.Log("volume set to " + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUMNE_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume is out of range");
        }
    }

    public static void SetDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(DIFFICULTY_KEY, difficulty);
    }
}