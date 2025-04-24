// Create new C# script named NavigationScript.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationScript : MonoBehaviour
{
    public void LoadNextLevel()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if(nextScene < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            Debug.Log("All diamonds collected!");
        }
    }
}
