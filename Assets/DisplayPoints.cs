using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Show the total unspentPoint which is experiencePoint that we have
 * Show the points per skill which is skill_deckPoint per skill
 * These are counted and upgraded in class Skill_Levels and this class is just showing on the screen
 */

public class DisplayPoints : MonoBehaviour
{
    private TextMeshPro unspentPointText;
    // unspent points - experience points
    public int unspentPoint = 113;

    private SkillManager skill_un_or_do;
    
    public DisplayPoints(int unspentPoint)
    {
        this.unspentPoint = unspentPoint;
    }

    private void Start()
    {
        unspentPointText.text = unspentPoint.ToString() + " UNSPENT POINTS";
    }

    /* these functions should be connected according to a Condition which is
     *  if left click to node - taking it from the Manager
     *      function1.1() that is deciding the unspentPoint - decrease the Unspent Point
     *      function2.1() that is printing/upgrading the Unspent Point Value
     *  if right click to node - taking it from the Manager
     *      function1.2() that is deciding the unspentPoint - increase the Unspent Point
     *      function2.2() that is printing/upgrading the Unspent Point Value
     */

    private void UnspentPointUpgrade()
    {
        // if left click to node - taking it from the Manager
        if (skill_un_or_do.clickIsRight == false)
        {
            if (unspentPoint <= 0)
            {
                Debug.Log("You have used the all points you have!");
            }
            else
            {
                unspentPoint--;
                unspentPointText.text = unspentPoint.ToString() + " UNSPENT POINTS";
            } 
        }
        // if right click to node - taking it from the Manager
        if (skill_un_or_do.clickIsRight == true)
        {
            if (unspentPoint >= 113)
            {
                Debug.Log("You have reached the maximum limit of Unspent Point!");
            }
            else
            {
                unspentPoint++;
                unspentPointText.text = unspentPoint.ToString() + " UNSPENT POINTS";
            }
        }
    }

}
