using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        StartCoroutine(LoadGameAfterDelay(0.50f));
    }

    IEnumerator LoadGameAfterDelay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadSceneAsync(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void OpenOptions()
    {
        SceneManager.LoadScene(2);
    }
    public void Level2()
    {
        SceneManager.LoadScene(3);
    }
    public void Final()
    {
        SceneManager.LoadScene(4);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
