using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinDemo : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            RevenirAuMenu();
        }
    }

    void RevenirAuMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Revenir au menu");
    }
}
