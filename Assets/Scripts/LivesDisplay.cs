using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] private float baseLives = 3f;
    [SerializeField] private int damage = 1;
    private float _lives = 10f;
    private Text _livesText;


    // Start is called before the first frame update
    void Start()
    {
        _lives = baseLives - PlayerPrefsController.GetDifficulty();
        Debug.Log("Level is " + PlayerPrefsController.GetDifficulty());
        Debug.Log("Current lives is " + _lives);
        _livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        _livesText.text = _lives.ToString();
    }

    public void TakeLife()
    {
        _lives -= damage;
        UpdateDisplay();

        if (_lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}