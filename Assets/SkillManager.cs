using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

/*
 * This is the class that makes:
 *    Color change red to green - green to red
 *    Left and Right Mouse Button activations are made here with OnMouseDown(left) and OnMouseOver(right)
 * Start method has Renderer and Skill objects and Skill object connected to score and
 * it contains experiencePoint starts with 50
 * skillDeckPoint starts with 0 and
 * maXSkill_deckPoint which will has the connection between Skill class with the list "maxSkillPointForEachNodeDeck"
 */

public class SkillManager : MonoBehaviour

{
   public Skill score;
   public DisplayPoints point;
   public ColorChange color;

   // In default there is no stop in skill update
   public bool maximumStopConditionDecider = false;

   public List<int> pointHolder = new List<int>();
   // every skill contains that point list
   public List<int> skillPointDeck = new List<int>();
   
   public bool clickIsRight;
   public bool ClickIsRight { get; set; }
   
   public void Start()
   {
      score = new Skill(5, 8);
      point = new DisplayPoints(113);
   }

   public void OnMouseDown()
   {
      // adding skill with left click - 0 is left
         if (Input.GetMouseButtonDown(0))
         {
            Debug.Log("Left Click");
            score.skill_deckPoint++;
            skillPointDeck.Add(1);

            if (score.skill_deckPoint > 0)
            {
               color.ColorChangeGreen();
            }

            if (pointHolder == null) ;
            pointHolder.Remove(1);

            PrintSkillDeckPoint();

            ClickIsRight = false;
         }
   }

   private void OnMouseOver()
   {
      // removing skill with right click - 1 is right
      if (Input.GetMouseButtonDown(1))
      {
         Debug.Log("Right Click");
         score.skill_deckPoint--;
         skillPointDeck.Remove(1);

         if (score.skill_deckPoint == 0)
         {
            color.ColorChangeRed();
         }
         
         // there is no need to have NULL check the because we have already have empty point list
         pointHolder.Add(1);

         PrintSkillDeckPoint();

         ClickIsRight = true;
      }
   }

   void PrintSkillDeckPoint()
   {
      foreach (int VARIABLE in skillPointDeck)
      {
         Debug.Log(VARIABLE);
      }
   }
}
