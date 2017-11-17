using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureWalk : MonoBehaviour {

    private HeadLookWalk lookWalk;
    private HeadGesture gesture;

    private void Start()
    {
        lookWalk = GetComponent<HeadLookWalk>();
        gesture = GameObject.Find("ReticleCursor").GetComponent<HeadGesture>();
    }

    private void Update()
    {
        if (gesture.isMovingDown)
        {
            lookWalk.isWalking = !lookWalk.isWalking; 
        }
    }
}
