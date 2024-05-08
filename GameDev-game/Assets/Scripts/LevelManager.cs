using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject tower; // Assign your tower in the inspector
    public GameObject endOfLevelScreen; // Assign your end of level screen in the inspector
    public GameObject menuButton; // Assign your menu button in the inspector
    public GameObject nextLevelButton; // Assign your next level button in the inspector

    void Start()
    {
        // Disable the end of level screen, menu button and next level button at the start of the game
        endOfLevelScreen.SetActive(false);
        menuButton.SetActive(false);
        nextLevelButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the tower has been destroyed
        if (tower == null)
        {
            EndLevel();
        }
    }

    void EndLevel()
    {
        // Enable the end of level screen, menu button and next level button
        endOfLevelScreen.SetActive(true);
        menuButton.SetActive(true);
        nextLevelButton.SetActive(true);
    }
}
