using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    private Defender _defender;

    private void OnMouseDown()
    {
        AttemptToPlaceDefenderAt(SnapToGrid(GetSquareClicked()));
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        _defender = defenderToSelect;
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var starDisplay = FindObjectOfType<StarDisplay>();
        var defenderCost = _defender.GetStarCost();
        if (starDisplay.HaveEnoughStars(defenderCost))
        {
            SpawnDefender(gridPos);
            starDisplay.SpendStars(defenderCost);
        }
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
        var newDefender = Instantiate(_defender, roundedPos, Quaternion.identity) as Defender;
    }
}