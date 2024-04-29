using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : GameManager
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (!collider2D.CompareTag("Player"))
            GameObject.Destroy(collider2D.gameObject);

        if (collider2D.CompareTag("Player"))
        {
            GameObject.Destroy(collider2D.gameObject);
            Death();
        }
    }
}
