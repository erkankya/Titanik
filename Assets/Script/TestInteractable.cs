using UnityEngine;

public class TestInteractable : MonoBehaviour, IInteractable
{
    // Executes the core logic when the player successfully interacts with this object
    public void Interact()
    {
        Debug.Log("Success! The player interacted with the test cube.");
    }

    // Returns the specific prompt string to be displayed on the player's UI
    public string GetInteractText()
    {
        return "Press E to Test";
    }
}