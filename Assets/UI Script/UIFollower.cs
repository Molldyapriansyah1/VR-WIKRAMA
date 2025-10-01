using UnityEngine;

public class UIBillboard : MonoBehaviour
{
    public Transform playerHead;

    void LateUpdate()
    {
        if (playerHead == null) return;

        // Rotate to face the player
        Vector3 lookDirection = transform.position - playerHead.position;
        lookDirection.y = 0; // keeps it upright (remove this if you want full tilt tracking)

        transform.rotation = Quaternion.LookRotation(lookDirection);
    }
}
