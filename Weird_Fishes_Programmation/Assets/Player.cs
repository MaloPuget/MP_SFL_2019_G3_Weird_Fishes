using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public Texture2D imgOptions;
    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthBar;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "Malus")
        {
            Debug.Log("Take 1 damage");
            TakeDamage(1);
        }

        if (coll.name == "BadFish")
        {
            Debug.Log("Take 1 damage");
            TakeDamage(1);
            if (Input.GetKeyDown(KeyCode.R))
            {
                Destroy(coll.gameObject);
            }
        }

        if (coll.name == "VeryBadFish")
        {
            Debug.Log("Take 1 damage");
            TakeDamage(1);
            if (Input.GetKeyDown(KeyCode.R))
            {
                Destroy(coll.gameObject);
            }
        }

        if (coll.name == "BadFish" && Input.GetKeyDown(KeyCode.R))
        {
            Destroy(coll.gameObject);
        }

        if (coll.name == "VeryBadFish" && Input.GetKeyDown(KeyCode.R))
        {
            Destroy(coll.gameObject);
        }

        if (coll.name == "Bonus")
        {
            Debug.Log("Take 2 bonus");
            GetBonus(2);
            Destroy(coll.gameObject);
        }
        if (coll.name == "orb")
        {
            Destroy(coll.gameObject);
            //yield return new WaitForSeconds(3);
            FinDemo();
        }
    }

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetBonus(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            FinDemo();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            RevenirAuMenu();
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene("Game Over");
            Debug.Log("GAME OVER");
        }
    }

    void GetBonus(int bonus)
    {
        currentHealth += bonus;
        healthBar.SetHealth(currentHealth);
    }

    void FinDemo()
    {
        SceneManager.LoadScene("FinDemo");
        Debug.Log("Fin de la démo");
    }
    void RevenirAuMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Revenir au menu");
    }
}
