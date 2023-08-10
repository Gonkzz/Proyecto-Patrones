using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SkillSystem skillSystem;
    private Rigidbody2D rb;

    private void Start()
    {
        // Initialize the skill system
        skillSystem = new SkillSystem();

        // Create instances of the skills
        ISkill dashSkill = new Dash(this); // Pass the reference to the MonoBehaviour

        // Get the player's Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();

        // Set the Rigidbody2D component to the Dash skill
        if (dashSkill is Dash dash)
        {
            dash.SetRigidbody2D(rb);
        }

        // Equip the Dash skill to the skill system (without the Rigidbody2D parameter)
        skillSystem.EquipSkill(KeyCode.LeftShift, dashSkill.ExecuteSkill);

        // Equip other skills as needed using skillSystem.EquipSkill(KeyCode, Action)
        // or skillSystem.EquipSkill(KeyCode, Action<Rigidbody2D>)

    }

    private void Update()
    {
        // Check for input to execute equipped skills via the skill system
        foreach (KeyCode key in skillSystem.GetSkillKeys())
        {
            if (Input.GetKeyDown(key))
            {
                skillSystem.ExecuteSkill(key, rb); // Pass the Rigidbody2D component to the skill if needed
            }
        }

        // Implement other player controls and behaviors
    }
}
