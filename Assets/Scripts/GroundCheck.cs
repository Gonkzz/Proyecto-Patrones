using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] public static bool IsGrounded { get; private set; } // Estado de "grounded"

    [SerializeField]private int groundedColliders; // Contador de colliders en el suelo

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Terrain"))
        {
            groundedColliders++;
            UpdateGroundedStatus();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Terrain"))
        {
            groundedColliders--;
            UpdateGroundedStatus();
        }
    }

    private void UpdateGroundedStatus()
    {
        IsGrounded = (groundedColliders > 0);
    }
}