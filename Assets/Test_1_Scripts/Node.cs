using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    // NODE = SKILL
    // What could a node has as variables:
    [SerializeField] private string name;
    
    [TextArea (2,5)][SerializeField]
    private string descriptionOfSkill;
    
    [SerializeField] private bool locked;   // There are several conditions to be locked and we cannot give point to it while it is locked
    // total experience points that we could use to achieve new skill node point or node
    [SerializeField] private int experiencePointForSkill;

    public int ExperiencePointForSkill
    {
        get => experiencePointForSkill;
        set => experiencePointForSkill = value;
    }

    [SerializeField] private int skill_level_point;
    
    public int SkillLevelPoint
    {
        get => skill_level_point;
        set => skill_level_point = value;
    }

    private SkillType _skillType;
    enum SkillType              // There will be several skill types - We could use ID or Tag something
    {
        Healing,
        HealingSpeed,
        Attack,
        AttackSpeed,
        Speed,
        Armor
    }      

    public Sprite skillSprite;
    
    // Constructor
    
}
