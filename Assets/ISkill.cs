using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* SKILL INTERFACE
 * Keep the base interface as simple as possible.
 * Only include the essential methods and properties that all concrete components will share.
 * The base interface should define the common functionality that all components must implement, such as getting and setting the skill points of a component.
 * If you have specific methods or properties that are only applicable to certain components, you should define them in separate interfaces.
 */

public interface ISkill
{
    string SkillName { get; } 
    string Description { get; } 
    int MaxSkillPoints { get; } 
    int SkillDeckPoints { get; set; } 
    Sprite SkillSprite { get; }
    
}
