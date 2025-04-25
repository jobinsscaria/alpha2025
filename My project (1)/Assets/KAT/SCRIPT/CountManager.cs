using UnityEngine;
using TMPro;
using System.Collections;

public class CountManager : MonoBehaviour
{
    private int count;
    [SerializeField] private TMP_Text countText;
    [SerializeField] private GameObject winTextObject;

    public string nextSceneName; // Name of the scene to load
    public int requiredGemCount = 20; // Number of gems needed to trigger the change

    void Start()
    {
        count = 0;
        SetCountText();
        if (winTextObject != null)
            winTextObject.SetActive(false);
    }

    public void IncrementCount()
    {
        count++;
        SetCountText();
    }

    private void SetCountText()
    {
        if (countText != null)
            countText.text = "Count: " + count.ToString();

        // Show win text when enough gems are collected
        if (count >= requiredGemCount && winTextObject != null)
            winTextObject.SetActive(true);

        // Change scene when enough gems are collected
        if (count >= requiredGemCount)
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
    }
}
