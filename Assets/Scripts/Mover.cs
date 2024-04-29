using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float MoveSpeed = 100f;

    void FixedUpdate()
    {
        if (transform.position.x <= -14)
            Destroy(gameObject);

        Vector2 targetMovePos = transform.position;
        targetMovePos.x -= MoveSpeed * Time.deltaTime;

        transform.position = targetMovePos; 
    }
}
