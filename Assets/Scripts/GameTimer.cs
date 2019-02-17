using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level time in SECONDS")] [SerializeField]
    private float levelTime = 10f;

    private bool _triggeredLevelFinished = false;

    // Update is called once per frame
    void Update()
    {
        if (_triggeredLevelFinished)
        {
            return;
        }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        var timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            _triggeredLevelFinished = true;
        }
    }
}