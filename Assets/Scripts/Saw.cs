using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public Vector3 rotation;
    public Transform saw;

    

    // Update is called once per frame
    void Update()
    {
        saw.Rotate(rotation, rotation.magnitude * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        var connectedBlocks = other.GetComponent<Block>();
        if (connectedBlocks)
        {
            connectedBlocks.DestroyBlock();
        }
      
    }
}
