using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float despawnTime = 5;
    [SerializeField] private int damage = 1;

    public void Shoot(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
        StartCoroutine(DespawnAfterTimeCoroutine());
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        HealthPointManager target = other.collider.GetComponent<HealthPointManager>();
        if(target != null)
            target.DealDamage(damage);
        Destroy(gameObject);
    }

    private IEnumerator DespawnAfterTimeCoroutine()
    {
        yield return new WaitForSeconds(despawnTime);
        Destroy(gameObject);
    }
}
