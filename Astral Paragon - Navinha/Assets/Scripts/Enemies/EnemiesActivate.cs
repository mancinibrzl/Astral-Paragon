using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesActivate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Inimigos>().AtivarInimigo();
        }
    }
}

