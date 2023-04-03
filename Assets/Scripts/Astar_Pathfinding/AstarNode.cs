using System;
using System.Collections.Generic;
using UnityEngine;


public class AstarNode
{
    // The position on the grid
    public Vector2Int gridPosition;

    // List of the nodes neighbours
    public List<AstarNode> neighbours = new List<AstarNode>();

    // Is the node an obstacle
    public bool isObstacle = false;

    // Distance from the point to node
    public int gCostDistanceFromStart = 0;

    // Disatance from node to goal
    public int hCostDistanceFromGoal = 0;

    // Total cost  of movement to the grid position
    public int fCostTotal;

    // The order in which it was placed
    public int pickedOrder = 0;


    public AstarNode(Vector2Int gridPosition_)
    {
        gridPosition = gridPosition_;
    }

}

