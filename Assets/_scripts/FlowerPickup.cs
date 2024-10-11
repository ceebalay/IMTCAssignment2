using UnityEngine;

public class Flower : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to the flower
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Controller")) // Check if the controller is touching the flower
        {
            PickFlower();
        }
    }

    private void PickFlower()
    {
        // Play the picking sound
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Additional logic for picking the flower (e.g., disabling it)
        gameObject.SetActive(false); // Example of disabling the flower GameObject
    }
}