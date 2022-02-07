using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthFirstSearch : MonoBehaviour
{
    public Node rootNote;
    public Node target;

    private void Start()
    {
        int stepCount = DFS(target);
        if (stepCount > -1)
        {
         Debug.Log(target.name + " was found in " + stepCount + " steps. ");
        }
        else
        {
            Debug.Log(target.name + " was not found. ");
        }
    }



    public int DFS(Node targetNode)
    { 
        Stack stack = new Stack(); //Stack the nodes, the last one is the next one visited
        List<Node> visitedNodes = new List<Node>(); //Tracks the visited nodes

        stack.Push(rootNote); //Push the root node to the stack

        while (stack.Count > 0) //While the stack is not empty
        {
          Node node = (Node)stack.Pop(); //Get the last stacked node
          visitedNodes.Add(node); //Visit the node

            foreach(Node child in node.children) //Loop through the children of node
            {
                if (visitedNodes.Contains(child) == false && stack.Contains(child) == false) //If the child has not been visit or added to the stack
                { 
                    if(child == targetNode) //Target node found
                    {
                        return visitedNodes.Count; //Return number of visited nodes 
                    }
                    stack.Push(child);
                }

            }
        }
        return -1;
    }
}
