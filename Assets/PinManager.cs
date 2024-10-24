using System.Collections.Generic;
using UnityEngine;

public class PinManager : MonoBehaviour
{
    // List of all pins
    public List<GameObject> pins = new List<GameObject>();

    // The minimum angle to determine if a pin is knocked over
    private float knockOverAngleThreshold = 100f; // Adjust to a value higher than 90

    // Check how many pins are knocked down
    public int GetFallenPinCount()
    {
        int fallenPinCount = 0;

        foreach (GameObject pin in pins)
        {
            if (IsPinKnockedOver(pin))
            {
                fallenPinCount++;
            }
        }

        return fallenPinCount;
    }

    // Check if a pin is knocked over (based on rotation angle)
    private bool IsPinKnockedOver(GameObject pin)
    {
        // Calculate the angle between the pin's current rotation and the default upright rotation
        float angle = Quaternion.Angle(pin.transform.rotation, Quaternion.identity);

        // Debug the angle for each pin to verify the calculation
        Debug.Log($"Pin {pin.name} Angle: {angle}");

        // If the angle exceeds the threshold (e.g., > 110 degrees), the pin is considered knocked over
        return angle > knockOverAngleThreshold;
    }
}
