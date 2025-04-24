using UnityEngine;
using TMPro;
using System.Collections;

public class CountManager : MonoBehaviour
{
    private int count;
    [SerializeField] private TMP_Text countText;
    [SerializeField] private GameObject winTextObject;

    // Add reference to your navigation script
    [SerializeField] private NavigationScript navScript; 

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

        if (count >= 1)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    private void SetCountText()
    {
        if (countText != null)
            countText.text = "Count: " + count.ToString();

        // Update win text activation
        if (count >= 20 && winTextObject != null)
            winTextObject.SetActive(true);
    }

    private IEnumerator HandleWinCondition()
    {
        // Show win text for 2 seconds
        yield return new WaitForSeconds(2f);

        // Trigger level change through navigation script
        if(navScript != null)
        {
            navScript.LoadNextLevel();
        }
        else
        {
            Debug.LogError("NavigationScript reference missing!");
        }
        
        // Optional: Reset counter if staying in same scene
        // count = 0;
        // winTextObject.SetActive(false);
    }
}
