using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level time in SECONDS")] [SerializeField]
    private float levelTime = 10f;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        var timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            Debug.Log("Level timer expired!!");
        }
    }
}