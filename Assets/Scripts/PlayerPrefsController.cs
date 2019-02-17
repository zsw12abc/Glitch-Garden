﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    private const string MASTER_VOLUME_KEY = "master volume";
    private const string DIFFICULTY_KEY = "difficulty";
    private const float MIN_VOLUMNE = 0f;
    private const float MAX_VOLUMNE = 1f;
    private const float MIN_DIFFICULTY = 0f;
    private const float MAX_DIFFICULTY = 2f;

    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUMNE && volume <= MAX_VOLUMNE)
        {
            Debug.Log("volume set to " + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume is out of range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= MIN_DIFFICULTY && difficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty is out of range");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}