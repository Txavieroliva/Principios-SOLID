using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack_S : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform puntoDisparo;

    private void Update()
    {
        DispararInput();
    }

    private void DispararInput()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    private void Disparar()
    {
        Instantiate(proyectilPrefab, puntoDisparo.position, puntoDisparo.rotation);
    }
}
