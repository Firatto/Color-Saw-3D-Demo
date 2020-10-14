using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int connectedBlocks;

    public bool origin;
    public bool connected;
    private Vector3 localPosition;
 
 
    public void OnCollisionEnter(Collision collision)
    {
        if( connected)
        {
            DestroyBlock();
        }
        if( origin)
        {
            GameManager gameover = gameObject.GetComponent<GameManager>();
            gameover.GameOver();
        }
        
    }

    public void DestroyBlock()
    {
        
        Destroy(gameObject);
    }
    public void NextLevel()
    {
        if(GameObject.FindWithTag("Connected") == null)
        {
            GameManager nextLevel = gameObject.GetComponent<GameManager>();
            nextLevel.LoadNextScene();
        }
        
    }
}
