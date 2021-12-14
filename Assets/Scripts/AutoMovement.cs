using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AutoMovement : MonoBehaviour
{
    //public GameObject target;

    public EditorPath followPath;

    public int CurrentWayPointID = 0;
    public float speed;
    private float reachDistance = 1.0f;
    public float rotationSpeed = 5.0f;
    //private int lastIndex;
    public string pathName;

    Vector3 lastPos;
    Vector3 currentPos;

    public AutoTrigger Grind;

    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(followPath.pathOjs[CurrentWayPointID].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, followPath.pathOjs[CurrentWayPointID].position, Time.deltaTime * speed);

        if (distance <= reachDistance)
        {
            CurrentWayPointID++;
            
        }
        
        if (Grind.isGrinding)
        {
            if (followPath.pathOjs.Last())
            {
                GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
                GameObject.Find("FPSController").GetComponent<CharacterController>().enabled = false;
                
            }
        }
        
        

    }



    
    /*
    public GameObject target;

    public GameObject[] wayPoints;

    //public GameObject Trigger;

    public int currentPoint;

    public float speed;

    public AutoTrigger Grind;

    //public bool isGrinding;

    //public CharacterController CC;
    public Rigidbody rb;
    //public FirstPersonController FPC;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Grind.isGrinding = true;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovingAlongWayPoints();
    }

    void MovingAlongWayPoints()
    {
        if (Grind.isGrinding)
        {
            //target.SetActive(false);
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
            GameObject.Find("FPSController").GetComponent<CharacterController>().enabled = false;
            //GameObject.Find("FPSController").GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log(Grind.isGrinding);
            
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

        
    }
    */
}
