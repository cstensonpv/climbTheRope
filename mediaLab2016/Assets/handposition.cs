using UnityEngine;
using System.Collections.Generic;
using Leap;
using Leap.Unity;

public class LeapBehavior : MonoBehaviour {
    LeapProvider provider;

    void Start ()
    {
        provider = FindObjectOfType<LeapProvider>() as LeapProvider;
    }

    void Update ()
    {
        Frame frame = provider.CurrentFrame;
        foreach (Hand hand in frame.Hands)
        {
            if (hand.IsLeft) {
                Vector3 leftHandPosition = hand.PalmPosition.ToVector3() +
                                     hand.PalmNormal.ToVector3() *
                                    (transform.localScale.y * .5f + .02f); //converting leap motion object vector to unity vector
                
            } else if (hand.IsRight) {
                Vector3 rightHandPosition = hand.PalmPosition.ToVector3() +
                                     hand.PalmNormal.ToVector3() *
                                    (transform.localScale.y * .5f + .02f);

            }
        }
    }
}