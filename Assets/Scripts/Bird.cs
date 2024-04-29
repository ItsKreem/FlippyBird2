using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float UpwardsForce = 200.000f;

    private Rigidbody2D _rigidbody;
    private Collider2D _collider;

    public AudioSource JumpAudio;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (_rigidbody == null)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (JumpAudio != null)
            {
                GameObject.Instantiate(JumpAudio, transform.position, Quaternion.identity);
            }
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * UpwardsForce);
            Debug.Log("We should flap upwards.");
        }
    }
}
