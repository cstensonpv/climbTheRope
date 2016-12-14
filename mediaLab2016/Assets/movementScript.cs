using UnityEngine;
using System.Collections;

public class movementScript : MonoBehaviour {

    public float movementFactor = 0.1f;
    public float movementSpeed = 1f;
    public float movementDelta = 0.01f;

    private Vector3 endPosition;
    private Vector3 directionVector;
    private bool isMoving = false;
    private Vector3 movingFrom;
    private Vector3 movingTo;
    private float movingStartTime;

    // Use this for initialization
    void Start () {
        //get goal
        endPosition = transform.FindChild("endPosition").position;
        directionVector = (endPosition - transform.position);
        directionVector = directionVector.normalized;
        directionVector.y = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (!isMoving)
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                //Move forward
                moveForward();
            }
            else if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                //Move backward
                transform.position -= directionVector * movementFactor;
            }
        }else
        {
            //Learp the movement;
            float distCovered = (Time.time - movingStartTime) * movementSpeed;
            float fracJourney = distCovered / Vector3.Distance(movingFrom, movingTo);
            transform.position = Vector3.Lerp(movingFrom, movingTo, fracJourney);

            if(Vector3.Distance(transform.position, movingTo) < movementDelta)
            {
                isMoving = false;
            }
        }
        
       
    }

    public void moveForward()
    {
        isMoving = true;
        movingFrom = transform.position;
        movingTo = transform.position + (directionVector * movementFactor);
        movingStartTime = Time.time;
    }
}
