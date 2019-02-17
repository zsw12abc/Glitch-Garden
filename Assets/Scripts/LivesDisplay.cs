using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] private int lives = 10;
    [SerializeField] private int damage = 1;
    private Text _livesText;


    // Start is called before the first frame update
    void Start()
    {
        _livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        _livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadYouLose();
        }
    }
}