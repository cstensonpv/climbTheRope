using UnityEngine;
using System.Collections.Generic;
using Leap;
using Leap.Unity;

public class handposition : MonoBehaviour {
    //LeapProvider provider;
    //Vector3 leftHandPosition;
    //Vector3 rightHandPosition;
    public Vector3 offset = new Vector3(0, -2, 0);
    public bool isLeft;

    GameObject Sphere;

    public GameObject spherePrefab;

    void Start ()
    {
        //provider = FindObjectOfType<LeapProvider>() as LeapProvider;


    }

    void Update ()
    {
        /*Frame frame = provider.CurrentFrame;
        foreach (Hand hand in frame.Hands)
        {
            if (isLeft && hand.IsLeft) {
                leftHandPosition = hand.PalmPosition.ToVector3() +
                                     hand.PalmNormal.ToVector3() *
                                    (transform.localScale.y * .5f + .02f); //converting leap motion object vector to unity vector
               

            } else if (!isLeft && hand.IsRight) {
                rightHandPosition = hand.PalmPosition.ToVector3() +
                                     hand.PalmNormal.ToVector3() *
                                    (transform.localScale.y * .5f + .02f);

            }
        }*/

        if (isLeft)
        {
            if (Sphere == null)
            {
                Sphere = Instantiate(spherePrefab);
                Sphere.transform.parent = GameObject.Find("PalmPosition").transform;
                //Sphere.transform.position = new Vector3(0, 0, 0);
            }

            
        }
        else
        {
            if (Sphere == null)
            {
                Sphere = Instantiate(spherePrefab);
                Sphere.transform.parent = GameObject.Find("PalmPosition").transform;
                //Sphere.transform.position = new Vector3(0, 0, 0);
            }

        }

        Sphere.transform.position = GameObject.Find("PalmPosition").transform.position;

    }
}