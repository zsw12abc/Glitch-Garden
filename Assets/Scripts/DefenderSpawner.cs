using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        var clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var worldPost = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPost;
    }

    private void SpawnDefender(Vector2 worldPost)
    {
        var newDefender = Instantiate(defender, worldPost, Quaternion.identity);
    }
}