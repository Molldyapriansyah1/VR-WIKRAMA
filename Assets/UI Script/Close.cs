using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public GameObject uiCanvas;

    public void ClosePanel()
    {
        if (uiCanvas != null)
            uiCanvas.SetActive(false);
    }
}
