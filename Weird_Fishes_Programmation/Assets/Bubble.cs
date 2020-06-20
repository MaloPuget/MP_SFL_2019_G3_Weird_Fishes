using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 1;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "BadFish" || coll.name == "VeryBadFish")
        {
            EnemyHealth enemy = coll.GetComponent<EnemyHealth>();
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
