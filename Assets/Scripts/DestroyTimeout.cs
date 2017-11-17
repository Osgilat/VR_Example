using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimeout : MonoBehaviour {

    public float timer = 15.0f;

    private void Start()
    {
        Destroy(gameObject, timer);
    }
}
