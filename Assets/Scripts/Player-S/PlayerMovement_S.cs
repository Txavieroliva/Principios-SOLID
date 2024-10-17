using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_S : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
