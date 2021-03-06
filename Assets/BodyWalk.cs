﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyWalk : MonoBehaviour {
    private HeadLookWalk lookWalk;
    private Transform head;
    private Transform body;

    private void Start()
    {
        lookWalk = GetComponent<HeadLookWalk>();
        head = Camera.main.transform;
        body = transform.Find("Body");
    }

    private void Update()
    {
        if (lookWalk.isWalking)
        {
            body.transform.rotation = Quaternion.Euler(new Vector3(0.0f, head.transform.eulerAngles.y, 0.0f));
        }
    }
}
