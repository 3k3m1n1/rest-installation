using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DimLightMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 force;
    public float timer;
    public float speed;
    
    //GameObject lightBall;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        StartCoroutine(Movement());
    }

    IEnumerator Movement()
    {
        rb.AddForce(Random.insideUnitSphere * speed, ForceMode.Force);
        yield return new WaitForSeconds(timer);
    }
    
}
