using UnityEngine;
using System.Collections;
using Leap.Unity;

public class climbTheRope : MonoBehaviour {

    private movementScript ms;

	// Use this for initialization
	void Start () {
        Debug.Log("starts climbTheRope");

        //findPlayer movementscript
        ms = GameObject.Find("Player").GetComponent<movementScript>();

    }
	
	// Update is called once per frame
	void Update () {

	
	}


    private bool IsHand(Collider other)
    {
        if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
            return true;
        else
            return false;
    }

    void OnTriggerEnter(Collider other)
    {
        ms.moveForward();

        Debug.Log("collide");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hej");
    }
}
