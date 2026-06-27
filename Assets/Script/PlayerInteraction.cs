using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    [Header("Interaction Settings")]
    public float interactRange = 3f;

    [Header("UI Elements")]
    public GameObject promptUI;
    public TextMeshProUGUI promptText;

    private Camera mainCam;

    // Initializes camera reference and ensures the interaction UI is hidden on start
    void Start()
    {
        mainCam = Camera.main;

        if (promptUI != null)
        {
            promptUI.SetActive(false);
        }
    }

    // Casts a ray from the center of the screen to detect interactable objects and listens for input
    void Update()
    {
        Ray ray = mainCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;

        bool hitInteractable = false;

        if (Physics.Raycast(ray, out hit, interactRange))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                hitInteractable = true;

                if (promptUI != null && promptText != null)
                {
                    promptText.text = interactable.GetInteractText();
                    promptUI.SetActive(true);
                }

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
        }

        if (!hitInteractable && promptUI != null)
        {
            promptUI.SetActive(false);
        }
    }
}