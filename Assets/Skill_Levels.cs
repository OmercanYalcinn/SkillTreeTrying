using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/*
 * Total unspentPoints (experiencePoint) is counted and upgraded here
 * Also the point every skill has is calculated here
 * The class Skill has the List named "maxPointsListEachNode"
 */

public class Skill_Levels : MonoBehaviour
{
    public bool decider;
    public int skillLevelPoint;

    // skillLevelPoint can be increased by choosing and increasing skill
    // actually skillLevelPoint is skillDeckPoint
    
    // public bool DeciderOfLevelUpdate(){}
        // if the skillLevelPoint > 5
            // decider = true;
            // Can be unlocked the skills after first Level Decider
        // if the skillLevelPoint > 10
            // Can be unlocked the skills after second Level Decider
            // decider = true;
        // if the skillLevelPoint > 20
            // decider = ture;
            // Can be unlocked the skills after third Level Decider
            
    
}
