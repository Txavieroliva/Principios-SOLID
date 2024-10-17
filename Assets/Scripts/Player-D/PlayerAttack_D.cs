using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack_D : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform puntoDisparo;
    private IPlayerInput playerInput;

    private void Start()
    {
        playerInput = new PlayerInput();
    }

    private void Update()
    {
        DispararInput();
    }

    private void DispararInput()
    {
        if(playerInput.estaDisparando())
        {
            Disparar();
        }
    }

    private void Disparar()
    {
        Instantiate(proyectilPrefab, puntoDisparo.position, puntoDisparo.rotation);
    }
}
