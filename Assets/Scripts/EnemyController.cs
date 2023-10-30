using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static Action OnTankDestroyed;

    private bool hitByBullet = false;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet" && !hitByBullet)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            OnTankDestroyed?.Invoke();

            hitByBullet = true;
        }
    }
}
