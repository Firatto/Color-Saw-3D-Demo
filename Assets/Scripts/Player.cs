using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 targetPos;
    public float speed = 1f;
    public float mouseToCube = 15f;

    void Start()
    {
        targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
    }

    void Update()
    {
        float distance = transform.position.z - Camera.main.transform.position.z + mouseToCube;
        targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        targetPos = Camera.main.ScreenToWorldPoint(targetPos);

        Vector3 follow = new Vector3(targetPos.x, targetPos.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, follow, speed * Time.deltaTime);

    }
    public void NextLevel()
    {
        if (GameObject.FindWithTag("Connected") == null)
        {
            GameManager nextLevel = gameObject.GetComponent<GameManager>();
            nextLevel.LoadNextScene();
        }

    }
}
