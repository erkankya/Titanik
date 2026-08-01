using UnityEngine;

public class ObjectiveTrigger : MonoBehaviour
{
    [Header("Trigger Settings")]
    public string newObjectiveMessage;
    public ObjectiveManager objectiveManager;

    // Detects when another object enters this trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Checks if the object entering the trigger is the Player
        if (other.CompareTag("Player"))
        {
            if (objectiveManager != null)
            {
                // Updates the objective via the manager
                objectiveManager.UpdateObjective(newObjectiveMessage);
            }

            // Destroys this trigger so the objective doesn't update multiple times
            Destroy(gameObject);
        }
    }
}