/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabilidadDisparo : IHabilidad
{
    public void Ejecutar(GameObject pActor)
    {
        // Implementa la lógica para la habilidad de disparo aquí
        Debug.Log("Disparando!");
    }
}


public class HabilidadDash : IHabilidad
{
    private float dashDistance = 5f;
    private float dashDuration = 0.2f;
    private float dashSpeed;
    private Vector2 dashDirection;
    private bool isDashing = false;

    public HabilidadDash(float dashSpeed)
    {
        this.dashSpeed = dashSpeed;
    }

    public void Ejecutar(GameObject pActor)
    {
        if (!isDashing && pActor.GetComponent<Rigidbody2D>() != null)
        {
            // Get the current movement direction
            dashDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

            // Check if the character is moving (not standing still)
            if (dashDirection != Vector2.zero)
            {
                isDashing = true;

                // Apply a quick dash force in the direction of movement
                pActor.GetComponent<Rigidbody2D>().AddForce(dashDirection * dashSpeed, ForceMode2D.Impulse);

                // Start the coroutine to reset the dash state after the duration
                pActor.GetComponent<ControladorPersonaje>().StartCoroutine(ResetDashState(pActor));
            }
        }
        else
        {
            Debug.LogError("pActor is null!");
        }
    }

    private IEnumerator ResetDashState(GameObject pActor)
    {
        // Wait for the dash duration
        yield return new WaitForSeconds(dashDuration);

        // Reset the velocity back to zero to stop the dash
        pActor.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        isDashing = false;
    }
}
*/