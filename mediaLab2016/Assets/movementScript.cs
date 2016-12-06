using UnityEngine;
using System.Collections;

public class movementScript : MonoBehaviour {

    public float movementFactor = 0.1f;

    private Vector3 endPosition;
    private Vector3 directionVector;

    // Use this for initialization
    void Start () {
        //get goal
        endPosition = transform.FindChild("endPosition").position;
        Debug.Log(endPosition);
        directionVector = (endPosition - transform.position);
        directionVector = directionVector.normalized;

        Debug.Log(directionVector);
        


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //Move forward
            moveForward();
        }else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            //Move forward
            transform.position -= directionVector * movementFactor;
        }
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    //Move forward
        //    transform.position += new Vector3(-movementFactor, 0, 0);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    //Move forward
        //    transform.position += new Vector3(movementFactor, 0, 0);
        //}

    }

    public void moveForward()
    {
        transform.position += directionVector * movementFactor;
    }
}
