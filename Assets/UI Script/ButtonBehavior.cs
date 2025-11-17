using UnityEngine;
using UnityEngine.Events;

public class VRWorldButton : MonoBehaviour
{
    public GameObject dialogUI;   // the UI panel you made
    public UnityEvent onPress;    // optional event for extra actions

    // Call this when button is pressed
    public void PressButton()
    {
        if (dialogUI != null)
            dialogUI.SetActive(true);

        onPress.Invoke();
    }
}


