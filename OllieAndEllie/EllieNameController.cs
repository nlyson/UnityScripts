/*
    Description: This script keeps the camera position at a given vertical offset.
    Rotation/Scale are fixed so those are set in the Unity editor.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllieNameController : MonoBehaviour
{
    public GameObject player;
    public float offset = 5.0f;     // Offset is public so it can be altered in the Unity editor

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Each frame, position the camera so that is offset units above the player.
        transform.position = player.transform.position + new Vector3(0.0f, offset, 0.0f);
    }
}
