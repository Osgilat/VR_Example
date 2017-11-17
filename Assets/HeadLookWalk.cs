using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookWalk : MonoBehaviour {

    public float velocity = 0.7f;
    public bool isWalking = false;

    private CharacterController controller;

    private Clicker clicker = new Clicker();

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (clicker.Clicked())
        {
            isWalking = !isWalking;
        }

        if (isWalking)
        {
            controller.SimpleMove(Camera.main.transform.forward * velocity);
        }
        /*
        Vector3 moveDirection = Camera.main.transform.forward;
        moveDirection *= velocity * Time.deltaTime;
        moveDirection.y = 0.0f;
        controller.Move(moveDirection);
        */
    }
}
