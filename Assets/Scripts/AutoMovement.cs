using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AutoMovement : MonoBehaviour
{
    //Think of using Waypoints the next time you visit this script.

    public GameObject target;

    public GameObject[] wayPoints;

    public GameObject Trigger;

    public int currentPoint;

    public float speed;

    public bool isGrinding;

    //public CharacterController CC;
    public Rigidbody rb;
    //public FirstPersonController FPC;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovingAlongWayPoints();
    }

    void MovingAlongWayPoints()
    {
        if (isGrinding)
        {
            //target.SetActive(false);
            GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
            GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;
            GameObject.Find("Player").GetComponent<Rigidbody>().isKinematic = false;
            transform.position = Vector3.Lerp(Vector3.up, Vector3.forward, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, wayPoints[currentPoint].transform.position) < 1)
            {
                currentPoint++;
            }
        }

        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Waypoint works");
            isGrinding = true;
        }

        /*
        if (other.gameObject.tag == "StartTrigger")
        {
            
            GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
            GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;
            GameObject.Find("Player").GetComponent<Rigidbody>().isKinematic = true;
            target.transform.Translate(Vector3.forward * Time.deltaTime);
            target.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            Debug.Log("Start Trigger works");
        }
        */
    }
    /*
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "ExitTrigger")
        {
            target.SetActive(true);
            

            

            Debug.Log("Exit Trigger works");
        }
        
        
    } */
}
