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
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth == 0)
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
}
