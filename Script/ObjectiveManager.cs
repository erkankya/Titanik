using UnityEngine;
using TMPro;

public class ObjectiveManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject objectiveUI;
    public TextMeshProUGUI objectiveText;

    // Sets the initial objective when the game starts
    void Start()
    {
        UpdateObjective("Escape your cabin.");
    }

    // Updates the UI text and ensures the objective panel is enabled
    public void UpdateObjective(string newObjective)
    {
        if (objectiveUI != null && objectiveText != null)
        {
            objectiveText.text = "Objective: " + newObjective;
            objectiveUI.SetActive(true);

            Debug.Log("Success: New Objective Set - " + newObjective);
        }
    }
}