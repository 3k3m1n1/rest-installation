﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DimLightMovement : MonoBehaviour
{
    /*
    [SerializeField] float speed = 10f;
    [SerializeField] float waitTime = 3f;
    float currentWaitTime = 0f;

    float minX, maxX, minZ, maxZ;
    Vector3 moveSpot;

    // Start is called before the first frame update
    void Start()
    {
        GetPointSize();
        moveSpot = GetNewPosition();
    }

    // Update is called once per frame
    void Update()
    {
        WatchYourStep();
        GetToStepping();
    }

    private void GetPointSize()
    {
        GameObject point = GameObject.FindWithTag("pointer");
        Renderer pointSize = point.GetComponent<Renderer>();
        minX = (pointSize.bounds.center.x - pointSize.bounds.extents.x);
        maxX = (pointSize.bounds.center.x + pointSize.bounds.extents.x);
        minZ = (pointSize.bounds.center.z - pointSize.bounds.extents.z);
        maxZ = (pointSize.bounds.center.z + pointSize.bounds.extents.z);
    }

    Vector3 GetNewPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);
        Vector3 newPosition = new Vector3(randomX, transform.position.y, randomZ);
        return newPosition;
    }

    void GetToStepping()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpot) <= 0.2f)
        {
            if (currentWaitTime <= 0)
            {
                moveSpot = GetNewPosition();
                currentWaitTime = waitTime;
            }
            else
            {
                currentWaitTime -= Time.deltaTime;
            }
        }
    }

    void WatchYourStep()
    {
        Vector3 targetDirection = moveSpot - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, 0.3f, 0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
    */

}