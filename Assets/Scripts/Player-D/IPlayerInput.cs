using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerInput
{
    float InputHorizontal();
    float InputVertical();
    bool estaDisparando();
}
