using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllieNameController : MonoBehaviour
{
    public GameObject player;
    public float offset = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0.0f, offset, 0.0f);
    }
}
