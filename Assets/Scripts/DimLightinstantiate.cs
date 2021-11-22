﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimLightinstantiate : MonoBehaviour
{
    public GameObject prefabInstantiate;
    //public GameObject ObjectToInstantiateON;

    public int width = 10;
    public int height = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnLightBall()
    {
        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                Instantiate(prefabInstantiate, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

    

    
}
