using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VerticaVelocityRotator : MonoBehaviour
{
    private Bird _player;

    public float RotateDown = -20f;
    public float RotateUp = 60f;

    private float _currentY;
    private float _lastY;

    private float _velocity = 0f;

    void Start()
    {
        _player = transform.parent.GetComponent<Bird>();
        _currentY = _lastY = transform.parent.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_player == null)
            return;

        _currentY = _player.transform.position.y;

        _velocity = _currentY - _lastY;

        _velocity *= 10f;

        _velocity = Unity.Mathematics.math.remap(-1, 1, 0, 1, _velocity);

        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 0, RotateDown), Quaternion.Euler(0, 0, RotateUp), _velocity);

        _lastY = _player.transform.position.y;
    }
}
