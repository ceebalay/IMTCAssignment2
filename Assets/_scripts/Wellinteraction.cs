using UnityEngine;

public class WellInteraction : MonoBehaviour
{
    public AudioSource splashSound; // Reference to the AudioSource

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the well is the metal bowl
        if (other.CompareTag("Bowl")) // Make sure the tag matches your bowl's tag
        {
            // Play the splash sound
            splashSound.Play();
        }
    }
}