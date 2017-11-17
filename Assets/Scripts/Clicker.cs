using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker {

	public bool Clicked()
    {
        return Input.GetButtonDown("Fire1");
    }
}
