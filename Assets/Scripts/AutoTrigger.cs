using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AutoTrigger : MonoBehaviour
{
    //public AnimationClip Upward;
    //public Animation anim;

    public bool isGrinding;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
        //anim.enabled = false;
        //anim.playAutomatically = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StartTrigger"))
        {
            //anim.enabled = true;
            //anim.Play();
            isGrinding = true;
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = true;
            GameObject.Find("FPSController").GetComponent<CharacterController>().enabled = true;
        }
        
    }
    /*
    public void ExitAnimation()
    {
        anim.Stop();
        transform.position = new Vector3(38.55f, 10.72f, -5.91f); 
        

    }
    */
}
