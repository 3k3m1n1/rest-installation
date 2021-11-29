using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AutoMovement : MonoBehaviour
{
    public GameObject target;

    //public CharacterController CC;
    //public Rigidbody rb;
    //public FirstPersonController FPC;

    //public Collider StartTrigger;
    //public Collider ExitTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "StartTrigger")
        {
            target.SetActive(false);
            GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
            GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;
            GameObject.Find("Player").GetComponent<Rigidbody>().isKinematic = true;

            target.transform.Translate(Vector3.forward * Time.deltaTime);
            target.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            Debug.Log("Start Trigger works");
        }
        
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "ExitTrigger")
        {
            target.SetActive(true);
            GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;
            GameObject.Find("Player").GetComponent<CharacterController>().enabled = true;
            GameObject.Find("Player").GetComponent<Rigidbody>().isKinematic = false;

            

            Debug.Log("Exit Trigger works");
        }
        
        
    }
}
