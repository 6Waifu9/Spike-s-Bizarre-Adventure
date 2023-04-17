using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int damage1;

    [SerializeField] private HealthController _healthControlller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        _healthControlller.playerHealth = _healthControlller.playerHealth - damage1;
        _healthControlller.UpdateHealth();
        gameObject.SetActive(false);
    }
}
