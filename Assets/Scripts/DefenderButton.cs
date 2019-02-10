using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (var defenderButton in buttons)
        {
            defenderButton.GetComponent<SpriteRenderer>().color = new Color32(85, 85, 85, 255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;
    }
}