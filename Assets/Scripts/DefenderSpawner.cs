using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject defender;

    private void OnMouseDown()
    {
        SpawnDefender(SnapToGrid(GetSquareClicked()));
    }

    private static Vector2 GetSquareClicked()
    {
        var clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var worldPost = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPost;
    }

    private static Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
        var newDefender = Instantiate(defender, roundedPos, Quaternion.identity);
    }
}