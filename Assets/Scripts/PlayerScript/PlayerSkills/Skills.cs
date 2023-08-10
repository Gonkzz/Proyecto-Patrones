using System.Collections;
using UnityEngine;

public class Dash : ISkill
{
    private bool isDashing = false;
    private MonoBehaviour monoBehaviour; // Reference to the MonoBehaviour that can start the coroutine
    private Rigidbody2D rb; // Reference to the Rigidbody2D component

    public Dash(MonoBehaviour mb)
    {
        monoBehaviour = mb;
    }

    public void SetRigidbody2D(Rigidbody2D playerRigidbody)
    {
        rb = playerRigidbody;
    }

    public void ExecuteSkill()
    {
        // Implement the dash behavior here
        if (!isDashing && rb != null)
        {
            isDashing = true;

            // Get the current movement direction of the player
            Vector2 dashDirection = rb.velocity.normalized;

            // Double the dash speed
            float dashDistance = 5f;
            float dashDuration = 0.25f;
            float dashSpeed = dashDistance / dashDuration;

            monoBehaviour.StartCoroutine(PerformDash(dashDirection, dashSpeed, dashDuration));
        }
    }

    private IEnumerator PerformDash(Vector2 direction, float speed, float duration)
    {
        float elapsedTime = 0f;
        Vector2 initialPosition = rb.position;
        Vector2 targetPosition = initialPosition + (direction * speed * duration);

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            rb.MovePosition(Vector2.Lerp(initialPosition, targetPosition, t));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the player reaches the target position exactly at the end of the dash
        rb.MovePosition(targetPosition);

        isDashing = false;
    }
}


public class Attack : ISkill
{
    public void ExecuteSkill()
    {
        // Implement the attack behavior here
        Debug.Log("Performing Attack!");
    }
}

public class Block : ISkill
{
    public void ExecuteSkill()
    {
        // Implement the block behavior here
        Debug.Log("Performing Block!");
    }
}
