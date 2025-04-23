using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class CountManager : MonoBehaviour
{
    private int count;
    [SerializeField] private TMP_Text countText; // Use TMP_Text for TextMeshPro
    [SerializeField] private GameObject winTextObject;

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

        if (count >= 12 && winTextObject != null)
            winTextObject.SetActive(true);
    }
}
