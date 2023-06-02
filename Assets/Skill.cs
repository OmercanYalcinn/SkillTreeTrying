using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * SKILL CLASS IMPLEMENTING ISkill Interface - right now there is no method inside of the interface and here
 * This class also named Concrete Class according to Decorate Design Pattern and the functionality
 * adding additional behaviors or responsibilities to object at runtime without modifying the existing code.
 */

public class Skill : MonoBehaviour, ISkill
{
    public string skillName;
    
    [TextArea (2,5)]
    public string description;

    // the maximum point per skill and this is also help to define stop condition
    public int maxSkill_deckPoint;
    // the point that is inside the skill e.g. 2/3
    public int skill_deckPoint;

    public SkillType skill_type;

    public enum SkillType
    {
        Healing,
        HealingSpeed,
        Attack,
        AttackSpeed,
        Speed,
        Armor
    }

    public Sprite skillSprite;

    public string SkillName { get; }
    public string Description { get; }
    public int MaxSkillPoints { get; }
    public int SkillDeckPoints { get; set; }
    SkillType Skill_Type { get; set; }
    public Sprite SkillSprite { get; }

    public Skill(string skillName, string description, int maxSkillDeckPoint, int skillDeckPoint, SkillType skillType, Sprite skillSprite)
    {
        SkillName = skillName;
        Description = description;
        MaxSkillPoints = maxSkillDeckPoint;
        SkillDeckPoints = skillDeckPoint;
        Skill_Type = skillType;
        SkillSprite = skillSprite;
    }
    
    // every skill has different maximum point and I could hold them here:
    public List<int> maxSkillPointForEachNodeDeck = new List<int> {8, 6, 1, 5, 3};

    public Skill(int skillDeckPoint, int maxSkill_deckPoint)
    {
        skill_deckPoint = skillDeckPoint;
        this.maxSkill_deckPoint = maxSkill_deckPoint;
    }
}
