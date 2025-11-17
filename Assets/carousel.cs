using UnityEngine;

public class CarouselController : MonoBehaviour
{
    public GameObject[] panels; // Assign Panel (0), Panel (1), etc. in Inspector
    private int currentPanelIndex = 0;

    public void ShowNextPanel()
    {
        // Hide current panel
        panels[currentPanelIndex].SetActive(false);

        // Increment index
        currentPanelIndex = (currentPanelIndex + 1) % panels.Length;

        // Show next panel
        panels[currentPanelIndex].SetActive(true);
    }
}
