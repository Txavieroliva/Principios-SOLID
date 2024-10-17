using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : IPlayerInput
{
    public float InputVertical()
    {
        return Input.GetAxis("Vertical");
    }

    public float InputHorizontal()
    {
        return Input.GetAxis("Horizontal");
    }

    public bool estaDisparando()
    {
        return Input.GetButtonDown("Fire1");
    }

}
