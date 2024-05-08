using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndButtons : MonoBehaviour
{
    public GameObject menuButton; 
    public GameObject nextLevelButton; 

   
    public void OnLevelEnd()
    {
        
        menuButton.SetActive(true);
        nextLevelButton.SetActive(true);
    }
}

