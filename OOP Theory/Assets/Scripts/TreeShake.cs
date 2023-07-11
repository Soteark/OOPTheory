using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeShake : MonoBehaviour
{
    float shakeForce = 4.0f;
    
    void OnMouseDrag() {
        ShakeTree();    
    }
    void ShakeTree()
    {
        // Move the Tree back and forth by a factor of 4 on the z axis
        //transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Sin(Time.time * shakeForce) * 4);


        // Using Rotation, rock the game object back and forth on the z axis
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time * shakeForce) * 4);

        // Harvest Action
        GetComponent<TreeBehavior>().Harvest(); // ABSTRACTION
    }
}
