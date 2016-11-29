using UnityEngine;
using System.Collections;

public class movementScript : MonoBehaviour {

    public float movementFactor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move forward
            transform.position += new Vector3(0,0 , movementFactor); 
        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move forward
            transform.position += new Vector3(0, 0, -movementFactor);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move forward
            transform.position += new Vector3(-movementFactor, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move forward
            transform.position += new Vector3(movementFactor, 0, 0);
        }

    }
}
