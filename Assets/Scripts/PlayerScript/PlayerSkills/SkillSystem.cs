using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillSystem
{
    private Dictionary<KeyCode, Action<Rigidbody2D>> equippedSkillsWithRB = new Dictionary<KeyCode, Action<Rigidbody2D>>();
    private Dictionary<KeyCode, Action> equippedSkillsWithoutRB = new Dictionary<KeyCode, Action>();

    public void EquipSkill(KeyCode key, Action skillAction)
    {
        equippedSkillsWithoutRB[key] = skillAction;
    }

    public void EquipSkill(KeyCode key, Action<Rigidbody2D> skillAction)
    {
        equippedSkillsWithRB[key] = skillAction;
    }

    public void UnequipSkill(KeyCode key)
    {
        equippedSkillsWithoutRB.Remove(key);
        equippedSkillsWithRB.Remove(key);
    }

    public void ExecuteSkill(KeyCode key, Rigidbody2D rb = null)
    {
        if (equippedSkillsWithoutRB.TryGetValue(key, out Action skillWithoutRB))
        {
            skillWithoutRB?.Invoke();
        }

        if (equippedSkillsWithRB.TryGetValue(key, out Action<Rigidbody2D> skillWithRB))
        {
            skillWithRB?.Invoke(rb);
        }
    }

    public IEnumerable<KeyCode> GetSkillKeys()
    {
        return equippedSkillsWithoutRB.Keys;
    }
}
