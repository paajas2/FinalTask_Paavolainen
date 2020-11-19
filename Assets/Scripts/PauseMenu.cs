using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    void Update()
    {

        if (pauseMenu.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {

            pauseMenu.SetActive(false);

        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {

            pauseMenu.SetActive(true);

        }

    }
}
