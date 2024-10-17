using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_D : MonoBehaviour
{
    public float speed = 5f;
    private IPlayerInput playerInput;

    private void Start()
    {
        playerInput = new PlayerInput();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveX = playerInput.InputHorizontal();
        float moveY = playerInput.InputVertical();

        Vector3 movement = new Vector3(moveX, 0.0f, moveY);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
