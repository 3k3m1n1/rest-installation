using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimLightinstantiate : MonoBehaviour
{
    public GameObject[] prefabInstantiate;
    //public GameObject ObjectToInstantiateON;

    public Transform pos;

    public int randomInt;

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
        randomInt = Random.Range(0, prefabInstantiate.Length);
        Instantiate(prefabInstantiate[randomInt], pos.position, pos.rotation);
    }

    

    
}
