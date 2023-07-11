using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloomyTreeBehavior : TreeBehavior // INHERITANCE
{
    bool scary = true; // POLYMORPHISM
    
    // set the tree health variable from the parent class
    void Awake()
    {
        treeHealth = 25.0f; // POLYMORPHISM
        woodQuantity = 5; // POLYMORPHISM
    }
}
