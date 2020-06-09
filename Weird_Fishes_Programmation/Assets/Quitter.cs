using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Quitter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            FermerApplication();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            RevenirAuMenu();
        }
    }

    void FermerApplication()
    {
        Application.Quit();
        Debug.Log("Quitter");
    }

    void RevenirAuMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Revenir au menu");
    }
}
