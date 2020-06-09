using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CommencerUnePartie();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            VoirLesOptions();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Quitter();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            RevenirAuMenu();
        }
    }

    void CommencerUnePartie()
    {
        SceneManager.LoadScene("Level 1");
        Debug.Log("Commencer une partie");
    }

    void VoirLesOptions()
    {
        SceneManager.LoadScene("Options");
        Debug.Log("Voir les options");
    }

    void Quitter()
    {
        SceneManager.LoadScene("Quitter");
        Debug.Log("Quitter");
    }

    void RevenirAuMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Revenir au menu");
    }
}
