using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Graph_of_SkillTree : MonoBehaviour
{
    private int numberOfNodes;
    private List<int>[] adjList;
    
    // Constructor
    Graph_of_SkillTree(int numberOfNodes)
    {
        this.numberOfNodes = numberOfNodes;
        adjList = new List<int>[this.numberOfNodes];
        for (int i = 0; i < numberOfNodes; i++)
        {
            adjList[i] = new List<int>();
        }
    }
    
    
}
